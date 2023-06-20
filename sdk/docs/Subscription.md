# Finbourne.Notifications.Sdk.Model.Subscription
A subscription object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the subscription | 
**Description** | **string** | The summary of the services provided by the subscription | [optional] 
**Status** | **string** | The current status of the subscription | 
**MatchingPattern** | [**MatchingPattern**](MatchingPattern.md) |  | 
**CreatedAt** | **DateTimeOffset** | The time at which the subscription was made | 
**UserIdCreated** | **string** | The user who made the subscription | 
**ModifiedAt** | **DateTimeOffset** | The time at which the subscription was last modified | 
**UserIdModified** | **string** | The user who last modified the subscription | 
**UseAsAuth** | **string** | The user to use as auth for the subscription | 
**Href** | **string** | A URI for retrieving this subscription | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

