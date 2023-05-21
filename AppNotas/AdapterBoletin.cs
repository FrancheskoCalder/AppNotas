using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppNotas
{
    internal class AdapterBoletin : BaseAdapter
    {
        Activity context;
        List<EstudianteGlobal.Notas> listaNotas;

        public AdapterBoletin(Activity context, List<EstudianteGlobal.Notas> listaNotas)
        {
            this.context = context;
            this.listaNotas = listaNotas;
        }

        public override int Count =>listaNotas.Count ;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = listaNotas[position];

            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Materia: "+item.Materia.Nombre;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = "Nota1: "+"\n"+item.Nota1.ToString() +"\nNota2: "+"\n"+item.Nota2.ToString()+"\nFinal: "+"\n"+item.NotaFinal;



            //devolvemos la lista
            return view;
        }
    }
}