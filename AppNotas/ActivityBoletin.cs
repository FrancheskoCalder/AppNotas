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
    [Activity(Label = "ActivityBoletin")]
    public class ActivityBoletin : Activity
    {
        EstudianteGlobal.Notas nota;
        TextView txtEstudiante,txtMateria;
        ListView lvEstudiante;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.VistaBoletin);
            int id = Intent.GetIntExtra("idEstudiante", 0);
            nota = EstudianteGlobal.notas.Where(x => x.Estudiante.IdEstudiante == id).FirstOrDefault();
            txtEstudiante = FindViewById<TextView>(Resource.Id.textView1);
            txtMateria= FindViewById<TextView>(Resource.Id.textView2);
            lvEstudiante = FindViewById<ListView>(Resource.Id.listView1);

            txtEstudiante.Text = nota.Estudiante.Nombre + " " + nota.Estudiante.Apellido;
            
            lvEstudiante.Adapter = new AdapterBoletin(this, EstudianteGlobal.notas.Where(x=>x.Estudiante.IdEstudiante==id).ToList());
        }
    }
}