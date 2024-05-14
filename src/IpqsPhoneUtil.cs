using Soenneker.Ipqs.Phone.Abstract;
using Soenneker.Utils.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Soenneker.Extensions.Configuration;
using Soenneker.Ipqs.Client.Abstract;
using Soenneker.Ipqs.Phone.Dtos;
using Soenneker.Extensions.HttpClient;
using System.Threading;

namespace Soenneker.Ipqs.Phone;

/// <inheritdoc cref="IIpqsPhoneUtil"/>
public class IpqsPhoneUtil: IIpqsPhoneUtil
{
    private readonly IIpqsClientUtil _ipqsClientUtil;
    private readonly ILogger<IpqsPhoneUtil> _logger;

    private readonly string _apiKey;
    private const string _baseUrl = "https://www.ipqualityscore.com/api/json/phone/";

    public IpqsPhoneUtil(IIpqsClientUtil ipqsClientUtil, IConfiguration config, ILogger<IpqsPhoneUtil> logger)
    {
        _apiKey = config.GetValueStrict<string>("Ipqs:ApiKey");
        _ipqsClientUtil = ipqsClientUtil;
        _logger = logger;
    }

    public async ValueTask<PhoneDetailsDto?> GetPhoneDetails(string number, CancellationToken cancellationToken = default)
    {
        var url = $"{_baseUrl}{_apiKey}/{number}?country[]=US";

        var result = await (await _ipqsClientUtil.Get()).SendToType<PhoneDetailsDto>(url, _logger, cancellationToken: cancellationToken);

        return result;
    }
}
