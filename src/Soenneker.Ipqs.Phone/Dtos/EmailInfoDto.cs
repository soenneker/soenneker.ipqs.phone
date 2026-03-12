using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Ipqs.Phone.Dtos;

public record EmailInfoDto
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("emails")]
    public List<string>? Emails { get; set; }
}