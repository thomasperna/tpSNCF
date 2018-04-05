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
    class AdapterFormation : ArrayAdapter<Formations>
    {

        Activity context;
        List<Formations> lesFormations;

        public AdapterFormation(Activity unContext, List<Formations> desFormations)
            : base(unContext, Resource.Layout.ItemFormation, desFormations)
        {
            this.context = unContext;
            lesFormations = desFormations;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = context.LayoutInflater.Inflate(Resource.Layout.ItemFormation, null);
            view.FindViewById<TextView>(Resource.Id.txtNomFormation).Text = lesFormations[position].libelle.ToString();


            return view;
        }

    }
}
        