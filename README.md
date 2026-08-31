[![](https://img.shields.io/nuget/v/soenneker.ipqs.phone.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.ipqs.phone/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.ipqs.phone/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.ipqs.phone/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.ipqs.phone.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.ipqs.phone/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.ipqs.phone/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.ipqs.phone/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Ipqs.Phone

Retrieve IPQualityScore validity, fraud, carrier, line-type, location, and risk details for US phone numbers.

## Install

```bash
dotnet add package Soenneker.Ipqs.Phone
```

## Configure and register

```json
{
  "Ipqs": {
    "ApiKey": "<API key>"
  }
}
```

```csharp
using Soenneker.Ipqs.Phone.Registrars;

services.AddIpqsPhoneUtilAsScoped();
```

The scoped phone service deliberately uses the singleton IPQS transport provider. Use `AddIpqsPhoneUtilAsSingleton()` when the operation layer should also live for the application lifetime.

## Usage

```csharp
using Soenneker.Ipqs.Phone.Abstract;
using Soenneker.Ipqs.Phone.Dtos;

PhoneDetailsDto? details = await phoneUtil.GetPhoneDetails(
    "+1 312 555 0123",
    cancellationToken);

if (details is { Success: true })
{
    bool acceptable = details.Valid && !details.Risky && !details.DoNotCall;
}
```

The request always sends `country[]=US`. The phone number and API key are escaped as URL path segments before the request is sent.

The response includes validity, activity, fraud score, recent abuse, VOIP/prepaid status, carrier, line type, location, do-not-call status, and potentially associated email addresses. Treat the result as sensitive personal data and avoid logging or retaining fields that are not needed.

HTTP, API, and deserialization failures are surfaced by the underlying request helper. A nullable result means no response body could be deserialized.
