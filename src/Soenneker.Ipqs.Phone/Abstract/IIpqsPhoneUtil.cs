using System.Threading;
using System.Threading.Tasks;
using Soenneker.Ipqs.Phone.Dtos;

namespace Soenneker.Ipqs.Phone.Abstract;

/// <summary>
/// Retrieves IPQualityScore validity, fraud, carrier, line-type, and risk details for US phone numbers.
/// </summary>
public interface IIpqsPhoneUtil
{
    /// <summary>
    /// Gets IPQualityScore details for a US phone number.
    /// </summary>
    /// <param name="number">The phone number to inspect.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The phone details, or <see langword="null"/> when no response body is available.</returns>
    ValueTask<PhoneDetailsDto?> GetPhoneDetails(string number, CancellationToken cancellationToken = default);
}
