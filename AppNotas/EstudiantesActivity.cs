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
using static Android.Provider.Settings;

namespace AppNotas
{
    [Activity(Label = "EstudiantesActivity")]
    public class EstudiantesActivity : Activity
    {
        ListView listEstudiant;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.VistaEstudiantes);

            listEstudiant= FindViewById<ListView>(Resource.Id.listView1);

            listEstudiant.Adapter = new adapterEstudiantes(EstudianteGlobal.estudiantes,this );

            listEstudiant.ItemClick += ListEstudiant_ItemClick;
        }

        private void ListEstudiant_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityBoletin));
            //obtenemos el id de la region seleccionada
            int idEstudiante = EstudianteGlobal.estudiantes[e.Position].IdEstudiante;
            //Pasamos el valor obtenido al siguiente Activity
            i.PutExtra("idEstudiante", idEstudiante);
            //Lanzamos o iniciamos la siguiente actividad 
            StartActivity(i);
        }
    }
}