using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Extensions;
using Finbourne.Notifications.Sdk.Model;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Finbourne.Notifications.Sdk.IntegrationTests;

[TestFixture]
public class UpsertNotificationsTests
{
    private IApiFactory _factory;
    private readonly string _subscriptionId = $"SDK_Subscription_{Guid.NewGuid()}";
    private readonly string _notificationId = $"SDK_Notification_{Guid.NewGuid()}";

    private string SubscriptionScope => $"Scope_{_subscriptionId}";
    private string SubscriptionCode => $"Code_{_subscriptionId}";

    private string NotificationId(CreateNotificationRequestNotificationType notificationType) =>
        $"{notificationType.ActualInstance.GetType().Name}_{_notificationId}";
    
    [OneTimeSetUp]
    public async Task OneTimeSetUp()
    {
        _factory = IntegrationTestApiFactoryBuilder.CreateApiFactory("secrets.json");
        await _factory.Api<SubscriptionsApi>().CreateSubscriptionAsync(new CreateSubscription(
            new ResourceId(SubscriptionScope, SubscriptionCode),
            "TestDisplayName",
            "TestDescription",
            status: "Active",
            matchingPattern: new MatchingPattern("Manual", "")));
    }

    [TestCaseSource(nameof(NotificationsToCreate))]
    public async Task CreateAndUpdateNotifications(
        CreateNotificationRequestNotificationType notificationTypeToCreate,
        CreateNotificationRequestNotificationType notificationTypeToUpdate,
        Action<object, object> customComparison)
    {
        var createdNotification = await _factory.Api<NotificationsApi>().CreateNotificationAsync(
            SubscriptionScope,
            SubscriptionCode,
            new CreateNotificationRequest(
                NotificationId(notificationTypeToCreate),
                "TestDisplayName",
                "TestDescription",
                notificationTypeToCreate));
        
        AssertNotificationCreatedAsExpected(notificationTypeToCreate, createdNotification.NotificationType);
        
        var updatedNotification = await _factory.Api<NotificationsApi>().UpdateNotificationAsync(
            SubscriptionScope,
            SubscriptionCode,
            NotificationId(notificationTypeToUpdate),
            new UpdateNotificationRequest(
                "TestDisplayName",
                "TestDescription",
                notificationTypeToUpdate));
        
        AssertNotificationCreatedAsExpected(notificationTypeToUpdate, updatedNotification.NotificationType);

        // Local functions

        void AssertNotificationCreatedAsExpected(AbstractOpenAPISchema expected, AbstractOpenAPISchema actual)
        {
            if (customComparison == null)
                Assert.That(actual.ActualInstance, Is.EqualTo(expected.ActualInstance));
            else
                customComparison(expected.ActualInstance, actual.ActualInstance);
        }
    } 
    
    private static IEnumerable<TestCaseData> NotificationsToCreate()
    {
        const string namePrefix = "Create";
        
        yield return Case(
            new CreateNotificationRequestNotificationType(Email(false)),
            new CreateNotificationRequestNotificationType(Email(true)),
            namePrefix);
        yield return Case(
            new CreateNotificationRequestNotificationType(Sms(false)),
            new CreateNotificationRequestNotificationType(Sms(true)),
            namePrefix);
        yield return Case(
            new CreateNotificationRequestNotificationType(AmazonSqs(false)),
            new CreateNotificationRequestNotificationType(AmazonSqs(true)),
            namePrefix);
        yield return Case(
            new CreateNotificationRequestNotificationType(Webhook(false)),
            new CreateNotificationRequestNotificationType(Webhook(true)),
            namePrefix,
            (expected, actual) => AssertWebhooksAreEqual(
                expected as WebhookNotificationType,
                actual as WebhookNotificationType));
    }

    private static TestCaseData Case(
        AbstractOpenAPISchema createData,
        AbstractOpenAPISchema updateData,
        string namePrefix,
        Action<object, object> customComparison = null) =>
        new TestCaseData(
            createData,
            updateData,
            customComparison).SetName($"{namePrefix} {createData.ActualInstance.GetType().Name}");
    
    private static EmailNotificationType Email(bool forUpdate) => new(
        "Email",
        forUpdate ? "subjectB" : "subjectA",
        forUpdate ? "plainTextBodyB" : "plainTextBodyA",
        forUpdate ? "htmlBodyB" : "htmlBodyA",
        new List<string> { forUpdate ? "address-b@unknown.com" : "address-a@unknown.com" },
        Enumerable.Empty<string>().ToList(),
        Enumerable.Empty<string>().ToList());

    private static SmsNotificationType Sms(bool forUpdate) => new(
        "Sms",
        forUpdate ? "bodyB" : "bodyA",
        new List<string>{forUpdate ? "+447700000001" : "+447700000000"});

    private static WebhookNotificationType Webhook(bool forUpdate) => new(
        "Webhook",
        "Post",
        $"https://{(forUpdate ? "example-b" : "example-a")}.com/api/{{{{id}}}}/path?examplequery={{{{id}}}}",
        "Lusid",
        authenticationConfigurationItemPaths: new Dictionary<string, string>(),
        contentType: "Json",
        content: new Dictionary<string, string>
        {
            { "Key", forUpdate ? "Value Example B" : "Value Example A" },
            { "MessageKey", "{{message}}" }
        });
    
    private static AmazonSqsNotificationType AmazonSqs(bool forUpdate) => new(
        "AmazonSqs",
        "config://shared/NotificationsService/IntegrationTests/testApiKeyRef",
        "config://shared/NotificationsService/IntegrationTests/testApiSecretRef",
        $"Event with message {{{{message}}}} {(forUpdate ? "B" : "A")}",
        "config://shared/NotificationsService/IntegrationTests/testQueueUrlRef");


    private static void AssertWebhooksAreEqual(WebhookNotificationType expected, WebhookNotificationType actual)
    {
        Assert.That(expected, Is.Not.Null);
        Assert.That(actual, Is.Not.Null);

        Assert.That(expected.Type, Is.EqualTo(actual.Type));
        Assert.That(expected.Type, Is.EqualTo(actual.Type));
        Assert.That(expected.HttpMethod, Is.EqualTo(actual.HttpMethod));
        Assert.That(expected.Url, Is.EqualTo(actual.Url));
        Assert.That(expected.AuthenticationType, Is.EqualTo(actual.AuthenticationType));
        Assert.That(expected.ContentType, Is.EqualTo(actual.ContentType));

        Assert.That(
            expected.AuthenticationConfigurationItemPaths,
            Is.EquivalentTo(actual.AuthenticationConfigurationItemPaths));
                
        Assert.That(
            (IDictionary<string, string>)expected.Content,
            Is.EquivalentTo(
                ((IDictionary<string,JToken>)actual.Content).ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.ToString())));
    }
}