using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEM_MATRICULAS
{
    class Administrador
    {

        List<Estudiante> lista_estudiantes_admon = new List<Estudiante>();
        List<Profesor> lista_profesores_admon = new List<Profesor>();
        List<Curso> lista_cursos_admon = new List<Curso>();



        public void crear_estudiante()
        {
            Estudiante estudiante = new Estudiante();
            lista_estudiantes_admon.Add(estudiante);

            Console.WriteLine("Ingrese el nombre del estudiante: \n");
            estudiante._nombre_estudiante = Console.ReadLine();

            Console.WriteLine("El estudiante " + estudiante._nombre_estudiante + "Ha sido registrado satisfactoriamente. ")
            return;
        }

        public void crear_profesor()
        {
            Profesor profesor = new Profesor();
            lista_profesores_admon.Add(profesor);

            Console.WriteLine("Ingrese el nombre del Profesor: \n");
            profesor._nombre_profesor = Console.ReadLine();

            Console.WriteLine("El profesor " + profesor._nombre_profesor + "Ha sido registrado satisfactoriamente. ")
            return;
        }


        public void crear_curso()
        {
            Curso curso = new Curso();
            lista_cursos_admon.Add(curso);

            Console.WriteLine("Ingrese el nombre del curso: \n");
            curso._nombre_curso= Console.ReadLine();

            Console.WriteLine("El curso " + curso._nombre_curso + "Ha sido registrado satisfactoriamente. ")
            return;
        }

        public void editar_estudiante()
        {
            string nombre_a_modificar;
            Console.WriteLine("Ingrese el Estudiante a Modificar: \n");
            nombre_a_modificar = Console.ReadLine();
            foreach (var nombre_estudiante in lista_estudiantes_admon)
            {
                if (nombre_a_modificar.Equals(nombre_estudiante))
                {
                    Console.WriteLine("Ingrese el nuevo nombre del estudiante corregido: ");
                    nombre_estudiante = Console.ReadLine();

                }
            }
        }

        public void editar_profesor()
        {
            string nombre_a_modificar;
            Console.WriteLine("Ingrese el profesor a Modificar: \n");
            nombre_a_modificar = Console.ReadLine();
            foreach (var nombre_profesor in lista_profesores_admon)
            {
                if (nombre_a_modificar.Equals(nombre_profesor))
                {
                    Console.WriteLine("Ingrese el nuevo nombre del profesor corregido: ");
                    nombre_profesor = Console.ReadLine();

                }
            }
        }
    }

    public void editar_curso()
    {
        string nombre_a_modificar;
        Console.WriteLine("Ingrese el curso a Modificar: \n");
        nombre_a_modificar = Console.ReadLine();
        foreach (var nombre_curso in lista_cursos_admon)
        {
            if (nombre_a_modificar.Equals(nombre_curso))
            {
                Console.WriteLine("Ingrese el nuevo nombre del curso corregido: ");
                nombre_curso = Console.ReadLine();

            }
        }
    }
}
