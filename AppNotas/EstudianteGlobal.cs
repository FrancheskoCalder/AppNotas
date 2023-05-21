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
    class EstudianteGlobal

    {
        public static List<Materia> materias = new List<Materia>()
        {
            new Materia(1,"Matematica"),
            new Materia(2,"Proyecto"),
            new Materia(3, "Historia"),
            new Materia(4,"Tecnologia"),
            new Materia(5,"Lengua"),
            new Materia(6,"Ingles"),

        };

        public static List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante (1,"Abel Gerardo","Aballay"),
            new Estudiante (2,"Ricardo","Aballay"),
            new Estudiante (3,"Roberto","Arredondo"),
            new Estudiante (4,"Martin Matias","Carrizo"),
            new Estudiante (5,"Mairo Leonardo","Castro"),
            new Estudiante (6,"German","Cruz-Molina"),
            new Estudiante (7,"Damian","Gonzalo Diaz"),
            new Estudiante (8,"Jose Luis","Godoy"),
            new Estudiante (9,"Juan Sebastian","Lopez"),
            new Estudiante (10,"Leandro David","Mallea"),
            new Estudiante (11,"Paulo G","Dybala"),
            new Estudiante (12,"Matias","Ontiveros"),
            new Estudiante (13,"Abel Gaston","Parada"),
            new Estudiante (14,"Pedro","Roel-Ahumada"),
            new Estudiante (15,"Ricardo Gabriel","Silva"),
            new Estudiante (16,"Renzo Edgardo","Tello"),
            new Estudiante (17,"Natalia Paola","Canizo"),
            new Estudiante (18,"Eugenia","Carrizo"),
            new Estudiante (19,"Yanina Anahi","Castro"),
            new Estudiante (20,"Daniela","Gonzalez"),
            new Estudiante (21,"Pamela E.","Molina"),
            new Estudiante (22,"Carolina","Ormeño"),
            new Estudiante (23,"Eliana","Palacio-Guardia"),
            new Estudiante (24,"Susana B","Quiroga"),
            new Estudiante (24,"Silvana","Torres"),
            new Estudiante (26,"Luis","Molina"),
            new Estudiante (27," ","Lopez"),
            new Estudiante (28,"Cintia","Molina"),
            new Estudiante (29,"Mario","Muñoz"),
            
        };

        public static List<Notas> notas = new List<Notas>()
        { 
          new Notas(7,7 , Notas.CalcularPromedio(7,7),estudiantes.Find(x=>x.IdEstudiante==1),materias.Find(x=>x.IdMateria==1) ),
          new Notas(8,5 , Notas.CalcularPromedio(8,5),estudiantes.Find(x=>x.IdEstudiante==1),materias.Find(x=>x.IdMateria==2) ),
          new Notas(5,8 , Notas.CalcularPromedio(5,8),estudiantes.Find(x=>x.IdEstudiante==1),materias.Find(x=>x.IdMateria==3) ),
          new Notas(6,9 , Notas.CalcularPromedio(6,9),estudiantes.Find(x=>x.IdEstudiante==1),materias.Find(x=>x.IdMateria==4) ),
          new Notas(7,8 , Notas.CalcularPromedio(7,8),estudiantes.Find(x=>x.IdEstudiante==2),materias.Find(x=>x.IdMateria==1) ),
          new Notas(10,6 , Notas.CalcularPromedio(10,6),estudiantes.Find(x=>x.IdEstudiante==2),materias.Find(x=>x.IdMateria==2) ),
          new Notas(8,5 , Notas.CalcularPromedio(8,5),estudiantes.Find(x=>x.IdEstudiante==2),materias.Find(x=>x.IdMateria==3) ),
          new Notas(4,6 , Notas.CalcularPromedio(4,6),estudiantes.Find(x=>x.IdEstudiante==2),materias.Find(x=>x.IdMateria==4) ),
          new Notas(6,5 , Notas.CalcularPromedio(6,5),estudiantes.Find(x=>x.IdEstudiante==3),materias.Find(x=>x.IdMateria==1) ),
          new Notas(8,7 , Notas.CalcularPromedio(8,7),estudiantes.Find(x=>x.IdEstudiante==3),materias.Find(x=>x.IdMateria==2) ),
          new Notas(6,7.5 , Notas.CalcularPromedio(6,7.5),estudiantes.Find(x=>x.IdEstudiante==3),materias.Find(x=>x.IdMateria==3) ),
          new Notas(7.5,9 , Notas.CalcularPromedio(7.5,9),estudiantes.Find(x=>x.IdEstudiante==3),materias.Find(x=>x.IdMateria==4) ),
          new Notas(7,7 , Notas.CalcularPromedio(7,7),estudiantes.Find(x=>x.IdEstudiante==4),materias.Find(x=>x.IdMateria==1) ),
          new Notas(8,5 , Notas.CalcularPromedio(8,5),estudiantes.Find(x=>x.IdEstudiante==4),materias.Find(x=>x.IdMateria==2) ),
          new Notas(5,8 , Notas.CalcularPromedio(5,8),estudiantes.Find(x=>x.IdEstudiante==4),materias.Find(x=>x.IdMateria==3) ),
          new Notas(6,9 , Notas.CalcularPromedio(6,9),estudiantes.Find(x=>x.IdEstudiante==4),materias.Find(x=>x.IdMateria==4) ),
          new Notas(7,8 , Notas.CalcularPromedio(7,8),estudiantes.Find(x=>x.IdEstudiante==5),materias.Find(x=>x.IdMateria==1) ),
          new Notas(7,7 , Notas.CalcularPromedio(7,7),estudiantes.Find(x=>x.IdEstudiante==5),materias.Find(x=>x.IdMateria==2) ),
          new Notas(10,6 , Notas.CalcularPromedio(10,6),estudiantes.Find(x=>x.IdEstudiante==5),materias.Find(x=>x.IdMateria==3) ),
          new Notas(8,5 , Notas.CalcularPromedio(8,5),estudiantes.Find(x=>x.IdEstudiante==5),materias.Find(x=>x.IdMateria==4) ),
          new Notas(4,6 , Notas.CalcularPromedio(4,6),estudiantes.Find(x=>x.IdEstudiante==6),materias.Find(x=>x.IdMateria==1) ),
          new Notas(6,5 , Notas.CalcularPromedio(6,5),estudiantes.Find(x=>x.IdEstudiante==6),materias.Find(x=>x.IdMateria==2) ),
          new Notas(8,7 , Notas.CalcularPromedio(8,7),estudiantes.Find(x=>x.IdEstudiante==6),materias.Find(x=>x.IdMateria==3) ),
          new Notas(6,7.5 , Notas.CalcularPromedio(6,7.5),estudiantes.Find(x=>x.IdEstudiante==6),materias.Find(x=>x.IdMateria==4) ),
          new Notas(7.5,9 , Notas.CalcularPromedio(7.5,9),estudiantes.Find(x=>x.IdEstudiante==6),materias.Find(x=>x.IdMateria==5) ),
          new Notas(7,7 , Notas.CalcularPromedio(7,7),estudiantes.Find(x=>x.IdEstudiante==6),materias.Find(x=>x.IdMateria==6) ),

        };

        public class Estudiante
        {
            int idEstudiante;
            string nombre;
            string apellido;

            public Estudiante(int idEstudiante, string nombre, string apellido)
            {
                this.idEstudiante = idEstudiante;
                this.nombre = nombre;
                this.apellido = apellido;
            }

            public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
        }

        public class Notas
        {
            double nota1;
            double nota2;
            double notaFinal;
            Estudiante estudiante;
            Materia materia;

            public Notas(double nota1, double nota2, double notaFinal, Estudiante estudiante, Materia materia)
            {
                this.nota1 = nota1;
                this.nota2 = nota2;
                this.notaFinal = notaFinal;
                this.estudiante = estudiante;
                this.materia = materia;
            }

            public double Nota1 { get => nota1; set => nota1 = value; }
            public double Nota2 { get => nota2; set => nota2 = value; }
            public double NotaFinal { get => notaFinal; set => notaFinal = value; }
            internal Estudiante Estudiante { get => estudiante; set => estudiante = value; }
            internal Materia Materia { get => materia; set => materia = value; }

            public  static double CalcularPromedio(double nota1, double nota2)
            {
                return (nota1 + nota2) / 2;

            }
        }

        public class Materia
        {
            int idMateria;
            string nombre;

            public Materia(int idMateria, string nombre)
            {
                this.idMateria = idMateria;
                this.nombre = nombre;
            }

            public int IdMateria { get => idMateria; set => idMateria = value; }
            public string Nombre { get => nombre; set => nombre = value; }
        }
       
    }
}