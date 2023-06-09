# Finbourne.Notifications.Sdk.Model.Subscription
A subscription object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | List of notifications belonging to a subscription | [optional] [readonly] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the subscription | 
**Description** | **string** | The summary of the services provided by the subscription | [optional] 
**Status** | **string** | The current status of the subscription | 
**MatchingPattern** | [**MatchingPattern**](MatchingPattern.md) |  | 
**CreatedAt** | **DateTimeOffset** | The time at which the subscription was made | 
**CreatedBy** | **string** | The user who made the subscription | [readonly] 
**LastModifiedAt** | **DateTimeOffset** | The time at which the subscription was last modified | [readonly] 
**LastModifiedBy** | **string** | The user who last modified the subscription | [readonly] 
**UseAsAuth** | **string** | The user to use as auth for the subscription | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

