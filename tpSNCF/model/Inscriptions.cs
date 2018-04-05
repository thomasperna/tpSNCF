using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace tpSNCF.model
{
    public class Inscriptions
    {
        [JsonProperty("numeroFormation")]
        public int code { get; set; }
        [JsonProperty("codeAgent")]
        public int agent { get; set; }
        [JsonProperty("presence")]
        public bool presence { get; set; }
    }
}