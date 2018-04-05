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
    public class Agents
    {
        [JsonProperty("code")]
        public int codeAgent { get; set; }
        [JsonProperty("nom")]
        public string nomAgent { get; set; }
    }
}