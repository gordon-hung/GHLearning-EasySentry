# GHLearning-EasySentry
[![GitHub Actions GHLearning-EasySentry](https://github.com/gordon-hung/GHLearning-EasySentry/actions/workflows/dotnet.yml/badge.svg)](https://github.com/gordon-hung/GHLearning-EasySentry/actions/workflows/dotnet.yml) [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/gordon-hung/GHLearning-EasySentry)
## ASP.NET Core
#### Learn about Sentry's .NET integration with ASP.NET Core.
Sentry provides an integration with ASP.NET Core through the [Sentry.AspNetCore](https://www.nuget.org/packages/Sentry.AspNetCore) NuGet package.

## Features
In addition to capturing errors, you can monitor interactions between multiple services or applications by enabling [tracing](https://docs.sentry.io/concepts/key-terms/tracing/).
Select which Sentry features you'd like to install in addition to Error Monitoring to get the corresponding installation and configuration instructions below.

## Install
```
Install-Package Sentry.AspNetCore -Version 5.5.1
```

## Initialize
```
builder.WebHost.UseSentry(); // Initialize Sentry
```

## Tracing
```
app.UseSentryTracing(); // Use Sentry Tracing
```

## Configure
```
  "Sentry": {
    "Dsn": "",
    "SendDefaultPii": true,
    "MaxRequestBodySize": "Always",
    "MinimumBreadcrumbLevel": "Debug",
    "MinimumEventLevel": "Information",
    "AttachStackTrace": false,
    "Debug": true,
    "DiagnosticLevel": "Warning",
    "TracesSampleRate": 1.0,
    "DefaultTags": {
      "ServiceName": "EasySentry-WebApi(local)",
      "Describe": "Gordon Hung Learning  Easy Sentry"
    }
  },
```

## Sources
- [ASP.NET Core Set Up Sentry](https://docs.sentry.io/platforms/dotnet/guides/aspnetcore/)
- [ASP.NET Core Set Up Tracing](https://docs.sentry.io/platforms/dotnet/guides/aspnetcore/tracing/)
