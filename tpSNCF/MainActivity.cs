using Android.App;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;
using System.Collections.Generic;
using tpSNCF.model;
using System.Net;
using System;
using Newtonsoft.Json;
using tpSNCF.adapter;

namespace tpSNCF
{
    [Activity(Label = "tpSNCF", MainLauncher = true)]
    public class MainActivity : Activity
    {

        List<Activites> lstActivite;
        List<Formations> lstFormation;
        ListView lvActivite;
        ListView lvFormation;
        AdapterActivite adapter;
        AdapterFormation adapterForm;
        Activites laActivite;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            lvActivite = FindViewById<ListView>(Resource.Id.lvActivites);
            lvFormation = FindViewById<ListView>(Resource.Id.lvFormations);

            WebClient wc = new WebClient();

            Uri url = new Uri("http://" + GetString(Resource.String.app_ip) + "GetAllActivites.php");

            wc.DownloadStringAsync(url);
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;

        }

        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            lstActivite = JsonConvert.DeserializeObject<List<Activites>>(e.Result);
            adapter = new AdapterActivite(this, lstActivite);
            lvActivite.Adapter = adapter;

            lvActivite.ItemClick += LvActivite_ItemClick;
        }

        private void LvActivite_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            laActivite = lstActivite[e.Position];

            WebClient wc = new WebClient();

            Uri url = new Uri("http://" + GetString(Resource.String.app_ip) + "GetFormationsByIdActivite.php?idActivite=" + laActivite.numActivite);

            wc.DownloadStringAsync(url);
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted1;

        }

        private void Wc_DownloadStringCompleted1(object sender, DownloadStringCompletedEventArgs e)
        {
            lstFormation = JsonConvert.DeserializeObject<List<Formations>>(e.Result);
            adapterForm = new AdapterFormation(this, lstFormation);
            lvFormation.Adapter = adapterForm;
        }
    }
}