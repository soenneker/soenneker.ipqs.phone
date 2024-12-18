using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Soenneker.Ipqs.Phone.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Ipqs.Phone.Tests;

[Collection("Collection")]
public class IpqsPhoneUtilTests : FixturedUnitTest
{
    private readonly IIpqsPhoneUtil _util;

    public IpqsPhoneUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IIpqsPhoneUtil>(true);
    }
}
