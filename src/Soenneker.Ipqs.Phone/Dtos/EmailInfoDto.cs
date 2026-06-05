using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Ipqs.Phone.Dtos;

/// <summary>
/// Represents the email info dto record.
/// </summary>
public record EmailInfoDto
{
    /// <summary>
    /// Gets or sets status.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets emails.
    /// </summary>
    [JsonPropertyName("emails")]
    public List<string>? Emails { get; set; }
}