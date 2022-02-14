# LUSID<sup>®</sup> Notifications SDK C#
![LUSID by Finbourne](https://content.finbourne.com/LUSID_repo.png)

This is the C# SDK for the Notification application, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account. [Sign up for free at lusid.com](https://www.lusid.com/app/signup).

The Notification application provides notifications via email, SMS or webhook when LUSID events occur.

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787/en-us).

## Installation

The NuGet package for the LUSID Notifications service SDK can installed from https://www.nuget.org/packages/Finbourne.Notifications.Sdk using the following:

```
$ dotnet add package Finbourne.Notifications.Sdk 
```

This C# SDK supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [Documentation - Release Lifecycle](https://www.lusid.com/app/resources/documentation/lifecycle). To find out which category an API endpoint falls into, see [FINBOURNE Notifications API Documentation](https://www.lusid.com/notifications/swagger/index.html).

## Build Status 

| branch | status |
| --- | --- |
| `master` |  ![Nuget](https://img.shields.io/nuget/v/Finbourne.Notifications.Sdk?color=blue) ![run-sdk-build](https://github.com/finbourne/finbourne-notifications-sdk-csharp/workflows/cron.yml/badge.svg)|