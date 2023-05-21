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
    internal class adapterEstudiantes : BaseAdapter
    {
        List<EstudianteGlobal.Estudiante> listaEstudiantes;
        Activity context;

        public adapterEstudiantes(List<EstudianteGlobal.Estudiante> listaEstudiantes, Activity context)
        {
            this.listaEstudiantes = listaEstudiantes;
            this.context = context;
        }

        public override int Count => listaEstudiantes.Count;

        
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
            var item = listaEstudiantes[position];
            
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre+" "+item.Apellido;
            

            //devolvemos la lista
            return view;
        }
    }
}