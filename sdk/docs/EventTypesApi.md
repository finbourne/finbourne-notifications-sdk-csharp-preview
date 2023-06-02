# Finbourne.Notifications.Sdk.Api.EventTypesApi

All URIs are relative to *https://www.lusid.com/notification*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEventType**](EventTypesApi.md#geteventtype) | **GET** /api/eventtypes/{eventType} | [EXPERIMENTAL] GetEventType: Gets the specified event type schema. |
| [**ListEventTypes**](EventTypesApi.md#listeventtypes) | **GET** /api/eventtypes | [EXPERIMENTAL] ListEventTypes: Lists all of the available event types. |

<a id="geteventtype"></a>
# **GetEventType**
> EventTypeSchema GetEventType (string eventType)

[EXPERIMENTAL] GetEventType: Gets the specified event type schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class GetEventTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventTypesApi(config);
            var eventType = "eventType_example";  // string | The event type to retrieve schema for.

            try
            {
                // [EXPERIMENTAL] GetEventType: Gets the specified event type schema.
                EventTypeSchema result = apiInstance.GetEventType(eventType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventTypesApi.GetEventType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetEventType: Gets the specified event type schema.
    ApiResponse<EventTypeSchema> response = apiInstance.GetEventTypeWithHttpInfo(eventType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventTypesApi.GetEventTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventType** | **string** | The event type to retrieve schema for. |  |

### Return type

[**EventTypeSchema**](EventTypeSchema.md)

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
| **404** | No event type exists with the specified type |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listeventtypes"></a>
# **ListEventTypes**
> ResourceListOfEventTypeSchema ListEventTypes ()

[EXPERIMENTAL] ListEventTypes: Lists all of the available event types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class ListEventTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventTypesApi(config);

            try
            {
                // [EXPERIMENTAL] ListEventTypes: Lists all of the available event types.
                ResourceListOfEventTypeSchema result = apiInstance.ListEventTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventTypesApi.ListEventTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEventTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListEventTypes: Lists all of the available event types.
    ApiResponse<ResourceListOfEventTypeSchema> response = apiInstance.ListEventTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventTypesApi.ListEventTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceListOfEventTypeSchema**](ResourceListOfEventTypeSchema.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | No event types found |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

