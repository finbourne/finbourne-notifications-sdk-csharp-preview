# Finbourne.Notifications.Sdk.Model.WebhookNotificationType
The information required to create or update a Webhook notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | 
**HttpMethod** | **string** | The HTTP method such as GET, POST, etc. to use on the request | 
**Url** | **string** | The URL to send the request to | 
**AuthenticationType** | **string** | The type of authentication to use on the request, can be one of the following values:  - Lusid -  Internal LUSID call  - BasicAuth - User specified Username and password  - BearerToken - Authorization header with Bearer scheme and user specified key  - None - No Authorization required on the webhook call | 
**AuthenticationConfigurationItemPaths** | **Dictionary&lt;string, string&gt;** | The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;  - None - None required                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      } | [optional] 
**ContentType** | **string** | The type of the content e.g. Json | 
**Content** | **Object** | The content of the request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

