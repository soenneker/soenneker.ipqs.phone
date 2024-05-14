using System.Text.Json.Serialization;

namespace Soenneker.Ipqs.Phone.Dtos;

public record PhoneDetailsDto
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("formatted")]
    public string? Formatted { get; set; }

    [JsonPropertyName("local_format")]
    public string? LocalFormat { get; set; }

    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    [JsonPropertyName("fraud_score")]
    public int FraudScore { get; set; }

    [JsonPropertyName("recent_abuse")]
    public bool RecentAbuse { get; set; }

    [JsonPropertyName("VOIP")]
    public bool Voip { get; set; }

    [JsonPropertyName("prepaid")]
    public bool Prepaid { get; set; }

    [JsonPropertyName("risky")]
    public bool Risky { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("carrier")]
    public string? Carrier { get; set; }

    [JsonPropertyName("line_type")]
    public string? LineType { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; set; }

    [JsonPropertyName("dialing_code")]
    public int DialingCode { get; set; }

    [JsonPropertyName("do_not_call")]
    public bool DoNotCall { get; set; }

    [JsonPropertyName("leaked")]
    public bool Leaked { get; set; }

    [JsonPropertyName("spammer")]
    public bool Spammer { get; set; }

    [JsonPropertyName("active_status")]
    public string? ActiveStatus { get; set; }

    [JsonPropertyName("user_activity")]
    public string? UserActivity { get; set; }

    [JsonPropertyName("associated_email_addresses")]
    public EmailInfoDto? AssociatedEmailAddresses { get; set; }

    [JsonPropertyName("mnc")]
    public string? Mnc { get; set; }

    [JsonPropertyName("mcc")]
    public string? Mcc { get; set; }

    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}