﻿using Newtonsoft.Json;

namespace CompaniesHouse.Response.Document
{
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }
        [JsonProperty("document")]
        public string Document { get; set; }
    }
}