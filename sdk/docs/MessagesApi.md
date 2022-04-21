# Finbourne.Notifications.Sdk.Api.MessagesApi

All URIs are relative to *https://www.lusid.com/notifications*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUndeliveredMessages**](MessagesApi.md#listundeliveredmessages) | **GET** /api/subscriptions/deliveries | [EXPERIMENTAL] ListUndeliveredMessages: List undelivered messages


<a name="listundeliveredmessages"></a>
# **ListUndeliveredMessages**
> ResourceListOfUndeliveredMessage ListUndeliveredMessages (string page = null, int? limit = null, string filter = null)

[EXPERIMENTAL] ListUndeliveredMessages: List undelivered messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class ListUndeliveredMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notifications";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi(config);
            var page = page_example;  // string | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied the filter field should not be supplied. (optional) 
            var limit = 56;  // int? | The maximum number of messages to retrieve. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about <see href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</see>. (optional) 

            try
            {
                // [EXPERIMENTAL] ListUndeliveredMessages: List undelivered messages
                ResourceListOfUndeliveredMessage result = apiInstance.ListUndeliveredMessages(page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ListUndeliveredMessages: " + e.Message );
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
 **page** | **string**| Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied the filter field should not be supplied. | [optional] 
 **limit** | **int?**| The maximum number of messages to retrieve. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. | [optional] 

### Return type

[**ResourceListOfUndeliveredMessage**](ResourceListOfUndeliveredMessage.md)

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
| **404** | No undelivered messages exists with the provided filter(s) |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

