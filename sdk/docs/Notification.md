# Finbourne.Notifications.Sdk.Model.Notification
A notification object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the notification | 
**Description** | **string** | The summary of the services provided by the notification | [optional] 
**DisplayName** | **string** | The name of the notification | [optional] 
**DeliveryChannel** | **string** | The medium through which the notification is delivered | 
**Recipients** | **Dictionary&lt;string, Object&gt;** | Recipient of the notification | 
**Content** | **Dictionary&lt;string, Object&gt;** | The contents of the notification | 
**Status** | [**NotificationStatus**](NotificationStatus.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset** | The time at which the subscription was made | 
**CreatedBy** | **string** | The user who made the subscription | 
**LastModifiedAt** | **DateTimeOffset** | The time at which the subscription was last modified | 
**LastModifiedBy** | **string** | The user who last modified the subscription | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

