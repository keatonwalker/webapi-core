﻿namespace api.mapserv.utah.gov.Models
{
    public class ApiKey
    {
        public enum ApplicationStatus
        {
            Development,
            Production,
            None
        }

        public enum ApplicationType
        {
            None,
            Browser,
            Server
        }

        public enum KeyStatus
        {
            None,
            Active,
            Disabled
        }

        public ApiKey(string apiKey)
        {
            Key = apiKey;
        }

        public string Key { get; set; }
        public KeyStatus ApiKeyStatus { get; set; }
        public ApplicationType Type { get; set; }
        public ApplicationStatus AppStatus { get; set; }
        public string Pattern { get; set; }
        public string RegexPattern { get; set; }
        public bool IsMachineName { get; set; }
        public bool Deleted { get; set; }
    }
}
