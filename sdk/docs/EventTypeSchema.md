# Finbourne.Notifications.Sdk.Model.EventTypeSchema
An EventType object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the event type | [optional] 
**EventName** | **string** | Identifier name of the event | [optional] [readonly] 
**Description** | **string** | The summary of the event | [optional] 
**Entity** | **string** | The entity against which the event originated | [optional] 
**Application** | **string** | The application associated with the event | [optional] 
**JsonSchema** | **Object** | The schema of the event | [optional] 
**HeaderSchema** | [**List&lt;EventFieldDefinition&gt;**](EventFieldDefinition.md) | The header schema for the event type | [optional] [readonly] 
**BodySchema** | [**List&lt;EventFieldDefinition&gt;**](EventFieldDefinition.md) | The body schema for the event type | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

