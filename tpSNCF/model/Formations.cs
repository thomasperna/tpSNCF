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
    public class Formations
    {
        [JsonProperty("code")]
        public int codeFormation { get; set; }
        [JsonProperty("intitule")]
        public string libelle { get; set; }
        [JsonProperty("numeroActivite")]
        public int numActivite { get; set; }
    }
}