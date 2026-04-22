using Soenneker.Ipqs.Phone.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Ipqs.Phone.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IpqsPhoneUtilTests : HostedUnitTest
{
    private readonly IIpqsPhoneUtil _util;

    public IpqsPhoneUtilTests(Host host) : base(host)
    {
        _util = Resolve<IIpqsPhoneUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
