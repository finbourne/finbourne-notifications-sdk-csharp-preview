# Finbourne.Notifications.Sdk.Model.Delivery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The identifier of the delivery. | 
**EventId** | **string** | The identifier of the associated event. | 
**SubscriptionId** | [**ResourceId**](ResourceId.md) |  | 
**NotificationId** | **Guid** | The identifier of the associated notification. | 
**DeliveryChannel** | **string** | The delivery channel of the message. | 
**MessageDetails** | **string** | The Details of the delivery message as JSON string. | 
**Attempts** | [**List&lt;Attempt&gt;**](Attempt.md) | A list of all the delivery attempts made for this message. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

