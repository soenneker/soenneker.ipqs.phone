using System.Text.Json.Serialization;

namespace Soenneker.Ipqs.Phone.Dtos;

/// <summary>
/// Represents the phone details dto record.
/// </summary>
public record PhoneDetailsDto
{
    /// <summary>
    /// Gets or sets message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether success.
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// Gets or sets formatted.
    /// </summary>
    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    /// <summary>
    /// Gets or sets local format.
    /// </summary>
    [JsonPropertyName("local_format")]
    public string? LocalFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether valid.
    /// </summary>
    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    /// <summary>
    /// Gets or sets fraud score.
    /// </summary>
    [JsonPropertyName("fraud_score")]
    public int FraudScore { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether recent abuse.
    /// </summary>
    [JsonPropertyName("recent_abuse")]
    public bool RecentAbuse { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether voip.
    /// </summary>
    [JsonPropertyName("VOIP")]
    public bool Voip { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether prepaid.
    /// </summary>
    [JsonPropertyName("prepaid")]
    public bool Prepaid { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether risky.
    /// </summary>
    [JsonPropertyName("risky")]
    public bool Risky { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets carrier.
    /// </summary>
    [JsonPropertyName("carrier")]
    public string? Carrier { get; set; }

    /// <summary>
    /// Gets or sets line type.
    /// </summary>
    [JsonPropertyName("line_type")]
    public string? LineType { get; set; }

    /// <summary>
    /// Gets or sets country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Gets or sets region.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Gets or sets city.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets timezone.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>
    /// Gets or sets zip code.
    /// </summary>
    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; set; }

    /// <summary>
    /// Gets or sets dialing code.
    /// </summary>
    [JsonPropertyName("dialing_code")]
    public int DialingCode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether do not call.
    /// </summary>
    [JsonPropertyName("do_not_call")]
    public bool DoNotCall { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether leaked.
    /// </summary>
    [JsonPropertyName("leaked")]
    public bool Leaked { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether spammer.
    /// </summary>
    [JsonPropertyName("spammer")]
    public bool Spammer { get; set; }

    /// <summary>
    /// Gets or sets active status.
    /// </summary>
    [JsonPropertyName("active_status")]
    public string? ActiveStatus { get; set; }

    /// <summary>
    /// Gets or sets user activity.
    /// </summary>
    [JsonPropertyName("user_activity")]
    public string? UserActivity { get; set; }

    /// <summary>
    /// Gets or sets associated email addresses.
    /// </summary>
    [JsonPropertyName("associated_email_addresses")]
    public EmailInfoDto? AssociatedEmailAddresses { get; set; }

    /// <summary>
    /// Gets or sets mnc.
    /// </summary>
    [JsonPropertyName("mnc")]
    public string? Mnc { get; set; }

    /// <summary>
    /// Gets or sets mcc.
    /// </summary>
    [JsonPropertyName("mcc")]
    public string? Mcc { get; set; }

    /// <summary>
    /// Gets or sets request id.
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}