# Finbourne.Notifications.Sdk.Api.ManualEventApi

All URIs are relative to *https://www.lusid.com/notification*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TriggerManualEvent**](ManualEventApi.md#triggermanualevent) | **POST** /api/manualevent | [EXPERIMENTAL] TriggerManualEvent: Trigger a manual event.


<a name="triggermanualevent"></a>
# **TriggerManualEvent**
> ManualEvent TriggerManualEvent (Object body)

[EXPERIMENTAL] TriggerManualEvent: Trigger a manual event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class TriggerManualEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ManualEventApi(config);
            var body = {"Body":{"subject":"TestSubject","message":"TestMessage","jsonMessage":{"TestField1":"TestValue1","TestField2":"TestValue2"}}};  // Object | The data required to trigger a manual event.

            try
            {
                // [EXPERIMENTAL] TriggerManualEvent: Trigger a manual event.
                ManualEvent result = apiInstance.TriggerManualEvent(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualEventApi.TriggerManualEvent: " + e.Message );
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
 **body** | **Object**| The data required to trigger a manual event. | 

### Return type

[**ManualEvent**](ManualEvent.md)

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

