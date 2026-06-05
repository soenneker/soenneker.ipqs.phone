using System.Threading;
using System.Threading.Tasks;
using Soenneker.Ipqs.Phone.Dtos;

namespace Soenneker.Ipqs.Phone.Abstract;

/// <summary>
/// A utility library for IPQualityScore phone related operations
/// </summary>
public interface IIpqsPhoneUtil
{
    /// <summary>
    /// Gets phone details.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<PhoneDetailsDto?> GetPhoneDetails(string number, CancellationToken cancellationToken = default);
}
