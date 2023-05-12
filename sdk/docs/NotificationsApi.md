# Finbourne.Notifications.Sdk.Api.NotificationsApi

All URIs are relative to *https://www.lusid.com/notification*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNotification**](NotificationsApi.md#createnotification) | **POST** /api/subscriptions/{scope}/{code}/notifications | [EXPERIMENTAL] CreateNotification: Add a notification to a subscription.
[**DeleteNotification**](NotificationsApi.md#deletenotification) | **DELETE** /api/subscriptions/{scope}/{code}/notifications/{id} | [EXPERIMENTAL] DeleteNotification: Delete a notification for a given subscription.
[**GetNotification**](NotificationsApi.md#getnotification) | **GET** /api/subscriptions/{scope}/{code}/notifications/{id} | [EXPERIMENTAL] GetNotification: Get a notification on a subscription.
[**ListNotifications**](NotificationsApi.md#listnotifications) | **GET** /api/subscriptions/{scope}/{code}/notifications | [EXPERIMENTAL] ListNotifications: List all notifications on a subscription.
[**UpdateNotification**](NotificationsApi.md#updatenotification) | **PUT** /api/subscriptions/{scope}/{code}/notifications/{id} | [EXPERIMENTAL] UpdateNotification: Update an email notification for a given subscription.


<a name="createnotification"></a>
# **CreateNotification**
> Notification CreateNotification (string scope, string code, CreateNotification createNotification)

[EXPERIMENTAL] CreateNotification: Add a notification to a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class CreateNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var createNotification = new CreateNotification(); // CreateNotification | The data to create a notification

            try
            {
                // [EXPERIMENTAL] CreateNotification: Add a notification to a subscription.
                Notification result = apiInstance.CreateNotification(scope, code, createNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateNotification: " + e.Message );
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
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **createNotification** | [**CreateNotification**](CreateNotification.md)| The data to create a notification | 

### Return type

[**Notification**](Notification.md)

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

<a name="deletenotification"></a>
# **DeleteNotification**
> void DeleteNotification (string scope, string code, string id)

[EXPERIMENTAL] DeleteNotification: Delete a notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class DeleteNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification

            try
            {
                // [EXPERIMENTAL] DeleteNotification: Delete a notification for a given subscription.
                apiInstance.DeleteNotification(scope, code, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteNotification: " + e.Message );
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
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 

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
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotification"></a>
# **GetNotification**
> Notification GetNotification (string scope, string code, string id)

[EXPERIMENTAL] GetNotification: Get a notification on a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class GetNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification

            try
            {
                // [EXPERIMENTAL] GetNotification: Get a notification on a subscription.
                Notification result = apiInstance.GetNotification(scope, code, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotification: " + e.Message );
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
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 

### Return type

[**Notification**](Notification.md)

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
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnotifications"></a>
# **ListNotifications**
> ResourceListOfNotification ListNotifications (string scope, string code)

[EXPERIMENTAL] ListNotifications: List all notifications on a subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class ListNotificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription

            try
            {
                // [EXPERIMENTAL] ListNotifications: List all notifications on a subscription.
                ResourceListOfNotification result = apiInstance.ListNotifications(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.ListNotifications: " + e.Message );
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
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 

### Return type

[**ResourceListOfNotification**](ResourceListOfNotification.md)

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
| **404** | No notifications exists with the provided filter(s) |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenotification"></a>
# **UpdateNotification**
> Notification UpdateNotification (string scope, string code, string id, UpdateNotification updateNotification)

[EXPERIMENTAL] UpdateNotification: Update an email notification for a given subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Notifications.Sdk.Api;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Example
{
    public class UpdateNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/notification";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi(config);
            var scope = scope_example;  // string | The scope that identifies a subscription
            var code = code_example;  // string | The code that identifies a subscription
            var id = id_example;  // string | The unique identifier of the notification
            var updateNotification = new UpdateNotification(); // UpdateNotification | The data to update a notification

            try
            {
                // [EXPERIMENTAL] UpdateNotification: Update an email notification for a given subscription.
                Notification result = apiInstance.UpdateNotification(scope, code, id, updateNotification);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateNotification: " + e.Message );
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
 **scope** | **string**| The scope that identifies a subscription | 
 **code** | **string**| The code that identifies a subscription | 
 **id** | **string**| The unique identifier of the notification | 
 **updateNotification** | [**UpdateNotification**](UpdateNotification.md)| The data to update a notification | 

### Return type

[**Notification**](Notification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No notification exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

