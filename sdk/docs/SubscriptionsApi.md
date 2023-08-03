# Finbourne.Notifications.Sdk.Api.SubscriptionsApi

All URIs are relative to *https://www.lusid.com/notification*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSubscription**](SubscriptionsApi.md#createsubscription) | **POST** /api/subscriptions | [EXPERIMENTAL] CreateSubscription: Create a new subscription. |
| [**DeleteSubscription**](SubscriptionsApi.md#deletesubscription) | **DELETE** /api/subscriptions/{scope}/{code} | [EXPERIMENTAL] DeleteSubscription: Delete a subscription. |
| [**GetSubscription**](SubscriptionsApi.md#getsubscription) | **GET** /api/subscriptions/{scope}/{code} | [EXPERIMENTAL] GetSubscription: Get a subscription. |
| [**ListSubscriptions**](SubscriptionsApi.md#listsubscriptions) | **GET** /api/subscriptions | [EXPERIMENTAL] ListSubscriptions: List subscriptions. |
| [**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PUT** /api/subscriptions/{scope}/{code} | [EXPERIMENTAL] UpdateSubscription: Update an existing subscription. |

<a id="createsubscription"></a>
# **CreateSubscription**
> Subscription CreateSubscription (CreateSubscription createSubscription)

[EXPERIMENTAL] CreateSubscription: Create a new subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var createSubscription = new CreateSubscription(); // CreateSubscription | The data to create a subscription

            try
            {
                // [EXPERIMENTAL] CreateSubscription: Create a new subscription.
                Subscription result = apiInstance.CreateSubscription(createSubscription);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CreateSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateSubscription: Create a new subscription.
    ApiResponse<Subscription> response = apiInstance.CreateSubscriptionWithHttpInfo(createSubscription);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.CreateSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSubscription** | [**CreateSubscription**](CreateSubscription.md) | The data to create a subscription |  |

### Return type

[**Subscription**](Subscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (string scope, string code)

[EXPERIMENTAL] DeleteSubscription: Delete a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription

            try
            {
                // [EXPERIMENTAL] DeleteSubscription: Delete a subscription.
                apiInstance.DeleteSubscription(scope, code);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DeleteSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteSubscription: Delete a subscription.
    apiInstance.DeleteSubscriptionWithHttpInfo(scope, code);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.DeleteSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No subscription exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsubscription"></a>
# **GetSubscription**
> Subscription GetSubscription (string scope, string code)

[EXPERIMENTAL] GetSubscription: Get a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription

            try
            {
                // [EXPERIMENTAL] GetSubscription: Get a subscription.
                Subscription result = apiInstance.GetSubscription(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetSubscription: Get a subscription.
    ApiResponse<Subscription> response = apiInstance.GetSubscriptionWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |

### Return type

[**Subscription**](Subscription.md)

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
| **404** | No subscription exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listsubscriptions"></a>
# **ListSubscriptions**
> ResourceListOfSubscription ListSubscriptions (string? filter = null, string? sortBy = null, string? page = null, int? limit = null)

[EXPERIMENTAL] ListSubscriptions: List subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class ListSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about <a href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</a>. (optional) 
            var sortBy = "sortBy_example";  // string? | Fields to order the result set. Read more about <a href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</a> (optional) 
            var page = "page_example";  // string? | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied the filter  field should not be supplied. (optional) 
            var limit = 56;  // int? | The maximum number of subscriptions to retrieve. (optional) 

            try
            {
                // [EXPERIMENTAL] ListSubscriptions: List subscriptions.
                ResourceListOfSubscription result = apiInstance.ListSubscriptions(filter, sortBy, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ListSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListSubscriptions: List subscriptions.
    ApiResponse<ResourceListOfSubscription> response = apiInstance.ListSubscriptionsWithHttpInfo(filter, sortBy, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.ListSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Expression to filter the result set. Read more about &lt;a href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/a&gt;. | [optional]  |
| **sortBy** | **string?** | Fields to order the result set. Read more about &lt;a href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/a&gt; | [optional]  |
| **page** | **string?** | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied the filter  field should not be supplied. | [optional]  |
| **limit** | **int?** | The maximum number of subscriptions to retrieve. | [optional]  |

### Return type

[**ResourceListOfSubscription**](ResourceListOfSubscription.md)

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
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesubscription"></a>
# **UpdateSubscription**
> Subscription UpdateSubscription (string scope, string code, UpdateSubscription updateSubscription)

[EXPERIMENTAL] UpdateSubscription: Update an existing subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SubscriptionsApi(httpClient, config, httpClientHandler);
            var scope = "scope_example";  // string | The scope that identifies a subscription
            var code = "code_example";  // string | The code that identifies a subscription
            var updateSubscription = new UpdateSubscription(); // UpdateSubscription | The data to update a subscription

            try
            {
                // [EXPERIMENTAL] UpdateSubscription: Update an existing subscription.
                Subscription result = apiInstance.UpdateSubscription(scope, code, updateSubscription);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateSubscription: Update an existing subscription.
    ApiResponse<Subscription> response = apiInstance.UpdateSubscriptionWithHttpInfo(scope, code, updateSubscription);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a subscription |  |
| **code** | **string** | The code that identifies a subscription |  |
| **updateSubscription** | [**UpdateSubscription**](UpdateSubscription.md) | The data to update a subscription |  |

### Return type

[**Subscription**](Subscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No subscription exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

