using Newtonsoft.Json;
using System;

namespace SimpleServer
{
    internal class Log
    {
        [JsonProperty("scan")]
        public Scan Scan { get; set; }

        [JsonProperty("files")]
        public Files[] Files { get; set; }
    }

    public class Scan
    {
        [JsonProperty("scanTime")]
        public DateTime ScanTime { get; set; }

        [JsonProperty("db")]
        public string Db { get; set; }

        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("errorCount")]
        public int ErrorCount { get; set; }
    }

    public class Files
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("scantime")]
        public DateTime Scantime { get; set; }
    }

    public class Error
    {
        [JsonProperty("module")]
        public string Module { get; set; }

        [JsonProperty("ecode")]
        public int Ecode { get; set; }

        [JsonProperty("error")]
        public string ErrorDesc { get; set; }
    }
}
