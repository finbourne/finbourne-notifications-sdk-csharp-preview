# Finbourne.Notifications.Sdk.Api.NotificationsApi

All URIs are relative to *https://www.lusid.com/notifications*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateASBNotification**](NotificationsApi.md#createasbnotification) | **POST** /api/subscriptions/{scope}/{code}/notifications/asb | [EXPERIMENTAL] CreateASBNotification: Add an Azure Service Bus notification to a subscription.
[**CreateAwsSqsNotification**](NotificationsApi.md#createawssqsnotification) | **POST** /api/subscriptions/{scope}/{code}/notifications/awssqs | [EXPERIMENTAL] CreateAwsSqsNotification: Add an AWS SQS notification to a subscription.
[**CreateAwsSqsPrincipalAuthNotification**](NotificationsApi.md#createawssqsprincipalauthnotification) | **POST** /api/subscriptions/{scope}/{code}/notifications/awssqsprincipalauth | [EXPERIMENTAL] CreateAwsSqsPrincipalAuthNotification: Add an AWS SQS notification with principal authentication to a subscription.
[**CreateEmailNotification**](NotificationsApi.md#createemailnotification) | **POST** /api/subscriptions/{scope}/{code}/notifications/email | [EXPERIMENTAL] CreateEmailNotification: Add an email notification to a subscription.
[**CreateSmsNotification**](NotificationsApi.md#createsmsnotification) | **POST** /api/subscriptions/{scope}/{code}/notifications/sms | [EXPERIMENTAL] CreateSmsNotification: Add an SMS notification to a subscription.
[**CreateWebhookNotification**](NotificationsApi.md#createwebhooknotification) | **POST** /api/subscriptions/{scope}/{code}/notifications/webhook | [EXPERIMENTAL] CreateWebhookNotification: Add a Webhook notification to a subscription.
[**DeleteNotification**](NotificationsApi.md#deletenotification) | **DELETE** /api/subscriptions/{scope}/{code}/notifications/{id} | [EXPERIMENTAL] DeleteNotification: Delete a notification for a given subscription.
[**GetNotification**](NotificationsApi.md#getnotification) | **GET** /api/subscriptions/{scope}/{code}/notifications/{id} | [EXPERIMENTAL] GetNotification: Get a notification on a subscription.
[**ListNotifications**](NotificationsApi.md#listnotifications) | **GET** /api/subscriptions/{scope}/{code}/notifications | [EXPERIMENTAL] ListNotifications: List all notifications on a subscription.
[**UpdateAwsSqsNotification**](NotificationsApi.md#updateawssqsnotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/awssqs/{id} | [EXPERIMENTAL] UpdateAwsSqsNotification: Update an AWS SQS notification for a given subscription.
[**UpdateAwsSqsPrincipalAuthNotification**](NotificationsApi.md#updateawssqsprincipalauthnotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/awssqsprincipalauth/{id} | [EXPERIMENTAL] UpdateAwsSqsPrincipalAuthNotification: Update an AWS SQS notification with principal authentication for a given subscription.
[**UpdateAzureServiceBusNotification**](NotificationsApi.md#updateazureservicebusnotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/asb/{id} | [EXPERIMENTAL] UpdateAzureServiceBusNotification: Update an Azure Service Bus notification for a given subscription.
[**UpdateEmailNotification**](NotificationsApi.md#updateemailnotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/email/{id} | [EXPERIMENTAL] UpdateEmailNotification: Update an email notification for a given subscription.
[**UpdateSmsNotification**](NotificationsApi.md#updatesmsnotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/sms/{id} | [EXPERIMENTAL] UpdateSmsNotification: Update an SMS notification for a given subscription.
[**UpdateWebhookNotification**](NotificationsApi.md#updatewebhooknotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/webhook/{id} | [EXPERIMENTAL] UpdateWebhookNotification: Update a Webhook notification for a given subscription.


<a name="createasbnotification"></a>
# **CreateASBNotification**
> Notification CreateASBNotification (string scope, string code, CreateAzureServiceBusNotification createAzureServiceBusNotification)

[EXPERIMENTAL] CreateASBNotification: Add an Azure Service Bus notification to a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateASBNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a notification
            var code = code_example;  // string | The code that identifies a notification
            var createAzureServiceBusNotification = new CreateAzureServiceBusNotification(); // CreateAzureServiceBusNotification | The data to create an message sent to Azure Service              Bus

            try
            {
                // [EXPERIMENTAL] CreateASBNotification: Add an Azure Service Bus notification to a subscription.
                Notification result = apiInstance.CreateASBNotification(scope, code, createAzureServiceBusNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateASBNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a notification | 
 **code** | **string**| The code that identifies a notification | 
 **createAzureServiceBusNotification** | [**CreateAzureServiceBusNotification**](CreateAzureServiceBusNotification.md)| The data to create an message sent to Azure Service              Bus | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createawssqsnotification"></a>
# **CreateAwsSqsNotification**
> Notification CreateAwsSqsNotification (string scope, string code, CreateAwsSqsNotification createAwsSqsNotification)

[EXPERIMENTAL] CreateAwsSqsNotification: Add an AWS SQS notification to a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateAwsSqsNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a notification
            var code = code_example;  // string | The code that identifies a notification
            var createAwsSqsNotification = new CreateAwsSqsNotification(); // CreateAwsSqsNotification | The data to create an message sent to AWS Simple Queue Service

            try
            {
                // [EXPERIMENTAL] CreateAwsSqsNotification: Add an AWS SQS notification to a subscription.
                Notification result = apiInstance.CreateAwsSqsNotification(scope, code, createAwsSqsNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateAwsSqsNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a notification | 
 **code** | **string**| The code that identifies a notification | 
 **createAwsSqsNotification** | [**CreateAwsSqsNotification**](CreateAwsSqsNotification.md)| The data to create an message sent to AWS Simple Queue Service | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createawssqsprincipalauthnotification"></a>
# **CreateAwsSqsPrincipalAuthNotification**
> Notification CreateAwsSqsPrincipalAuthNotification (string scope, string code, CreateAwsSqsPrincipalAuthNotification createAwsSqsPrincipalAuthNotification)

[EXPERIMENTAL] CreateAwsSqsPrincipalAuthNotification: Add an AWS SQS notification with principal authentication to a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateAwsSqsPrincipalAuthNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a notification
            var code = code_example;  // string | The code that identifies a notification
            var createAwsSqsPrincipalAuthNotification = new CreateAwsSqsPrincipalAuthNotification(); // CreateAwsSqsPrincipalAuthNotification | The data to create an message sent to AWS Simple Queue Service

            try
            {
                // [EXPERIMENTAL] CreateAwsSqsPrincipalAuthNotification: Add an AWS SQS notification with principal authentication to a subscription.
                Notification result = apiInstance.CreateAwsSqsPrincipalAuthNotification(scope, code, createAwsSqsPrincipalAuthNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateAwsSqsPrincipalAuthNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a notification | 
 **code** | **string**| The code that identifies a notification | 
 **createAwsSqsPrincipalAuthNotification** | [**CreateAwsSqsPrincipalAuthNotification**](CreateAwsSqsPrincipalAuthNotification.md)| The data to create an message sent to AWS Simple Queue Service | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemailnotification"></a>
# **CreateEmailNotification**
> Notification CreateEmailNotification (string scope, string code, CreateEmailNotification createEmailNotification)

[EXPERIMENTAL] CreateEmailNotification: Add an email notification to a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateEmailNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var createEmailNotification = new CreateEmailNotification(); // CreateEmailNotification | The data to create a email notification

            try
            {
                // [EXPERIMENTAL] CreateEmailNotification: Add an email notification to a subscription.
                Notification result = apiInstance.CreateEmailNotification(scope, code, createEmailNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateEmailNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **createEmailNotification** | [**CreateEmailNotification**](CreateEmailNotification.md)| The data to create a email notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsmsnotification"></a>
# **CreateSmsNotification**
> Notification CreateSmsNotification (string scope, string code, CreateSmsNotification createSmsNotification)

[EXPERIMENTAL] CreateSmsNotification: Add an SMS notification to a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateSmsNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var createSmsNotification = new CreateSmsNotification(); // CreateSmsNotification | The data to create an SMS notification

            try
            {
                // [EXPERIMENTAL] CreateSmsNotification: Add an SMS notification to a subscription.
                Notification result = apiInstance.CreateSmsNotification(scope, code, createSmsNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateSmsNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **createSmsNotification** | [**CreateSmsNotification**](CreateSmsNotification.md)| The data to create an SMS notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwebhooknotification"></a>
# **CreateWebhookNotification**
> Notification CreateWebhookNotification (string scope, string code, CreateWebhookNotification createWebhookNotification)

[EXPERIMENTAL] CreateWebhookNotification: Add a Webhook notification to a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateWebhookNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var createWebhookNotification = new CreateWebhookNotification(); // CreateWebhookNotification | The data to create a webhook notification

            try
            {
                // [EXPERIMENTAL] CreateWebhookNotification: Add a Webhook notification to a subscription.
                Notification result = apiInstance.CreateWebhookNotification(scope, code, createWebhookNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateWebhookNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **createWebhookNotification** | [**CreateWebhookNotification**](CreateWebhookNotification.md)| The data to create a webhook notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenotification"></a>
# **DeleteNotification**
> void DeleteNotification (string scope, string code, string id)

[EXPERIMENTAL] DeleteNotification: Delete a notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class DeleteNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification

            try
            {
                // [EXPERIMENTAL] DeleteNotification: Delete a notification for a given subscription.
                apiInstance.DeleteNotification(scope, code, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotification"></a>
# **GetNotification**
> Notification GetNotification (string scope, string code, string id)

[EXPERIMENTAL] GetNotification: Get a notification on a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class GetNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification

            try
            {
                // [EXPERIMENTAL] GetNotification: Get a notification on a subscription.
                Notification result = apiInstance.GetNotification(scope, code, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnotifications"></a>
# **ListNotifications**
> ResourceListOfNotification ListNotifications (string scope, string code)

[EXPERIMENTAL] ListNotifications: List all notifications on a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class ListNotificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription

            try
            {
                // [EXPERIMENTAL] ListNotifications: List all notifications on a subscription.
                ResourceListOfNotification result = apiInstance.ListNotifications(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.ListNotifications: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 

### Return type

[**ResourceListOfNotification**](ResourceListOfNotification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notifications exists with the provided filter(s) |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateawssqsnotification"></a>
# **UpdateAwsSqsNotification**
> Notification UpdateAwsSqsNotification (string scope, string code, string id, UpdateAwsSqsNotification updateAwsSqsNotification)

[EXPERIMENTAL] UpdateAwsSqsNotification: Update an AWS SQS notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateAwsSqsNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a notification
            var code = code_example;  // string | The code that identifies a notification
            var id = id_example;  // string | The unique identifier of the notification
            var updateAwsSqsNotification = new UpdateAwsSqsNotification(); // UpdateAwsSqsNotification | The data to update a notification

            try
            {
                // [EXPERIMENTAL] UpdateAwsSqsNotification: Update an AWS SQS notification for a given subscription.
                Notification result = apiInstance.UpdateAwsSqsNotification(scope, code, id, updateAwsSqsNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateAwsSqsNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a notification | 
 **code** | **string**| The code that identifies a notification | 
 **id** | **string**| The unique identifier of the notification | 
 **updateAwsSqsNotification** | [**UpdateAwsSqsNotification**](UpdateAwsSqsNotification.md)| The data to update a notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateawssqsprincipalauthnotification"></a>
# **UpdateAwsSqsPrincipalAuthNotification**
> Notification UpdateAwsSqsPrincipalAuthNotification (string scope, string code, string id, UpdateAwsSqsPrincipalAuthNotification updateAwsSqsPrincipalAuthNotification)

[EXPERIMENTAL] UpdateAwsSqsPrincipalAuthNotification: Update an AWS SQS notification with principal authentication for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateAwsSqsPrincipalAuthNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a notification
            var code = code_example;  // string | The code that identifies a notification
            var id = id_example;  // string | The unique identifier of the notification
            var updateAwsSqsPrincipalAuthNotification = new UpdateAwsSqsPrincipalAuthNotification(); // UpdateAwsSqsPrincipalAuthNotification | The data to update a notification

            try
            {
                // [EXPERIMENTAL] UpdateAwsSqsPrincipalAuthNotification: Update an AWS SQS notification with principal authentication for a given subscription.
                Notification result = apiInstance.UpdateAwsSqsPrincipalAuthNotification(scope, code, id, updateAwsSqsPrincipalAuthNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateAwsSqsPrincipalAuthNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a notification | 
 **code** | **string**| The code that identifies a notification | 
 **id** | **string**| The unique identifier of the notification | 
 **updateAwsSqsPrincipalAuthNotification** | [**UpdateAwsSqsPrincipalAuthNotification**](UpdateAwsSqsPrincipalAuthNotification.md)| The data to update a notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateazureservicebusnotification"></a>
# **UpdateAzureServiceBusNotification**
> Notification UpdateAzureServiceBusNotification (string scope, string code, string id, UpdateAzureServiceBusNotification updateAzureServiceBusNotification)

[EXPERIMENTAL] UpdateAzureServiceBusNotification: Update an Azure Service Bus notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateAzureServiceBusNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a notification
            var code = code_example;  // string | The code that identifies a notification
            var id = id_example;  // string | The unique identifier of the notification
            var updateAzureServiceBusNotification = new UpdateAzureServiceBusNotification(); // UpdateAzureServiceBusNotification | The data to update a notification

            try
            {
                // [EXPERIMENTAL] UpdateAzureServiceBusNotification: Update an Azure Service Bus notification for a given subscription.
                Notification result = apiInstance.UpdateAzureServiceBusNotification(scope, code, id, updateAzureServiceBusNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateAzureServiceBusNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a notification | 
 **code** | **string**| The code that identifies a notification | 
 **id** | **string**| The unique identifier of the notification | 
 **updateAzureServiceBusNotification** | [**UpdateAzureServiceBusNotification**](UpdateAzureServiceBusNotification.md)| The data to update a notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailnotification"></a>
# **UpdateEmailNotification**
> Notification UpdateEmailNotification (string scope, string code, string id, UpdateEmailNotification updateEmailNotification)

[EXPERIMENTAL] UpdateEmailNotification: Update an email notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateEmailNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification
            var updateEmailNotification = new UpdateEmailNotification(); // UpdateEmailNotification | The data to update a notification

            try
            {
                // [EXPERIMENTAL] UpdateEmailNotification: Update an email notification for a given subscription.
                Notification result = apiInstance.UpdateEmailNotification(scope, code, id, updateEmailNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateEmailNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 
 **updateEmailNotification** | [**UpdateEmailNotification**](UpdateEmailNotification.md)| The data to update a notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesmsnotification"></a>
# **UpdateSmsNotification**
> Notification UpdateSmsNotification (string scope, string code, string id, UpdateSmsNotification updateSmsNotification)

[EXPERIMENTAL] UpdateSmsNotification: Update an SMS notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateSmsNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification
            var updateSmsNotification = new UpdateSmsNotification(); // UpdateSmsNotification | The data to update a notification

            try
            {
                // [EXPERIMENTAL] UpdateSmsNotification: Update an SMS notification for a given subscription.
                Notification result = apiInstance.UpdateSmsNotification(scope, code, id, updateSmsNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateSmsNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 
 **updateSmsNotification** | [**UpdateSmsNotification**](UpdateSmsNotification.md)| The data to update a notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhooknotification"></a>
# **UpdateWebhookNotification**
> Notification UpdateWebhookNotification (string scope, string code, string id, UpdateWebhookNotification updateWebhookNotification)

[EXPERIMENTAL] UpdateWebhookNotification: Update a Webhook notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateWebhookNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification
            var updateWebhookNotification = new UpdateWebhookNotification(); // UpdateWebhookNotification | The data to update a notification

            try
            {
                // [EXPERIMENTAL] UpdateWebhookNotification: Update a Webhook notification for a given subscription.
                Notification result = apiInstance.UpdateWebhookNotification(scope, code, id, updateWebhookNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateWebhookNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 
 **updateWebhookNotification** | [**UpdateWebhookNotification**](UpdateWebhookNotification.md)| The data to update a notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

