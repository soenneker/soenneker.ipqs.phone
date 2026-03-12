using System.Threading;
using System.Threading.Tasks;
using Soenneker.Ipqs.Phone.Dtos;

namespace Soenneker.Ipqs.Phone.Abstract;

/// <summary>
/// A utility library for IPQualityScore phone related operations
/// </summary>
public interface IIpqsPhoneUtil
{
    ValueTask<PhoneDetailsDto?> GetPhoneDetails(string number, CancellationToken cancellationToken = default);
}
