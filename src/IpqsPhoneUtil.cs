using Soenneker.Ipqs.Phone.Abstract;
using Soenneker.Utils.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Configuration;
using Soenneker.Extensions.Configuration;
using Soenneker.Ipqs.Client.Abstract;
using Soenneker.Ipqs.Phone.Dtos;
using Soenneker.Extensions.HttpClient;

namespace Soenneker.Ipqs.Phone;

/// <inheritdoc cref="IIpqsPhoneUtil"/>
public class IpqsPhoneUtil: IIpqsPhoneUtil
{
    private readonly IIpqsClientUtil _ipqsClientUtil;

    private readonly string _apiKey;
    private const string _baseUrl = "https://www.ipqualityscore.com/api/json/phone/";

    public IpqsPhoneUtil(IIpqsClientUtil ipqsClientUtil, IConfiguration config)
    {
        _apiKey = config.GetValueStrict<string>("Ipqs:ApiKey");
        _ipqsClientUtil = ipqsClientUtil;
    }

    public async ValueTask<PhoneDetailsDto?> GetPhoneDetails(string number)
    {
        var url = $"{_baseUrl}{_apiKey}/{number}?country[]=US";

        var result = await (await _ipqsClientUtil.Get()).SendToType<PhoneDetailsDto>(url);

        return result;
    }
}
