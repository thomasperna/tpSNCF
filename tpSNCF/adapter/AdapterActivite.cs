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
using tpSNCF.model;

namespace tpSNCF.adapter
{
    class AdapterActivite : ArrayAdapter<Activites>
    {

        Activity context;
        List<Activites> lesActivites;

        public AdapterActivite(Activity unContext, List<Activites> desActivites) : base(unContext, Resource.Layout.ItemActivite, desActivites)
        {
            this.context = unContext;
            this.lesActivites = desActivites;
        }




        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = context.LayoutInflater.Inflate(Resource.Layout.ItemActivite, null);
            view.FindViewById<TextView>(Resource.Id.txtNumero).Text = lesActivites[position].numActivite.ToString();
            view.FindViewById<TextView>(Resource.Id.txtLibelle).Text = lesActivites[position].libelleActivite.ToString();


            return view;
        }
    }
}