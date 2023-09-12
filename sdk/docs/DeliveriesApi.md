# Finbourne.Notifications.Sdk.Api.DeliveriesApi

All URIs are relative to *https://www.lusid.com/notifications*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDeliveries**](DeliveriesApi.md#listdeliveries) | **GET** /api/deliveries | [EXPERIMENTAL] ListDeliveries: List Deliveries


<a name="listdeliveries"></a>
# **ListDeliveries**
> ResourceListOfDelivery ListDeliveries (string page = null, int? limit = null, string filter = null)

[EXPERIMENTAL] ListDeliveries: List Deliveries

Currently only returns deliveries with failed attempts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class ListDeliveriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveriesApi(config);
            var page = page_example;  // string | The pagination token to use to continue listing delivery attempts. This value is returned from the previous call. When this field is supplied the filter field should not be supplied. (optional) 
            var limit = 56;  // int? | The maximum number of delivery attempts to retrieve. Defaults to 200 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914.  By default, we set this filter to only query for the last week's worth of Deliveries, however if a filter is explicitly set, this will be overriden.  An example filter to override the attempt time date might be 'AttemptTime gt 2023-08-25' for example (optional) 

            try
            {
                // [EXPERIMENTAL] ListDeliveries: List Deliveries
                ResourceListOfDelivery result = apiInstance.ListDeliveries(page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveriesApi.ListDeliveries: " + e.Message );
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
 **page** | **string**| The pagination token to use to continue listing delivery attempts. This value is returned from the previous call. When this field is supplied the filter field should not be supplied. | [optional] 
 **limit** | **int?**| The maximum number of delivery attempts to retrieve. Defaults to 200 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914.  By default, we set this filter to only query for the last week&#39;s worth of Deliveries, however if a filter is explicitly set, this will be overriden.  An example filter to override the attempt time date might be &#39;AttemptTime gt 2023-08-25&#39; for example | [optional] 

### Return type

[**ResourceListOfDelivery**](ResourceListOfDelivery.md)

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
| **404** | No deliveries exists with the provided filter(s) |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

