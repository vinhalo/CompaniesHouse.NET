using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.DocumentMetadata
{
    public class DocumentMetadata
    {
        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("resources")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IDictionary<MimeType, Resource> Resources { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Links
    {
        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public enum MimeType
    {
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf = 1,

        [EnumMember(Value = "application/json")]
        ApplicationJson,

        [EnumMember(Value = "application/xml")]
        ApplicationXml,

        [EnumMember(Value = "application/xhtml+xml")]
        ApplicationXhtmlXml,

        [EnumMember(Value = "text/csv")]
        TextCsv
    }

    public class Resource
    {
        [JsonProperty("content_length")]
        public int ContentLength { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

}
