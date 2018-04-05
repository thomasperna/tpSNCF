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
    public class Activites
    {
        [JsonProperty("numero")]
        public int numActivite { get; set; }

        [JsonProperty("ancienReleve")]
        public string libelleActivite { get; set; }
    }
}