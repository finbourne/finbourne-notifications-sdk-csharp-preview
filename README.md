# LUSID<sup>®</sup> Notification SDK C# (Preview)
![LUSID by Finbourne](https://content.finbourne.com/LUSID_repo.png)

This is the C# SDK (Preview) for the Notification application, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account. [Sign up for free at lusid.com](https://www.lusid.com/app/signup).

The Notification application provides notifications via email, SMS, webhook or Amazon SQS when LUSID events occur.

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787/en-us).

## Installation

The NuGet package for the FINBOURNE Notification service SDK (Preview) can installed from https://www.nuget.org/packages/Finbourne.Notification.Sdk.Preview using the following:

```
$ dotnet add package Finbourne.Notification.Sdk.Preview
```

This C# SDK (Preview) supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [Documentation - Release Lifecycle](https://www.lusid.com/app/resources/documentation/lifecycle). To find out which category an API endpoint falls into, see [FINBOURNE Notifications API Documentation](https://www.lusid.com/notifications/swagger/index.html).

## Build Status 

| branch | status                                                                                                                                                                                                                                                                                                         |
|--------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `v2`   | ![Nuget](https://img.shields.io/nuget/v/Finbourne.Notifications.Sdk.Preview?color=blue) [![Build](https://github.com/finbourne/notifications-sdk-csharp-preview/actions/workflows/build.yaml/badge.svg?branch=v2)](https://github.com/finbourne/notifications-sdk-csharp-preview/actions/workflows/build.yaml?query=branch%3Av2++) |