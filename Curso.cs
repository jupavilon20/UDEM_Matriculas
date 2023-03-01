using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEM_MATRICULAS
{
    class Curso
    {
        private string nombre_curso;
        List<Estudiante> lista_estudiantes = new List<Estudiante>();


        public string _nombre_curso
        {
            get { return nombre_curso; }
            set { nombre_curso = value; }

        }

        public List<Estudiante> _lista_estudiantes
        {
            get { return lista_estudiantes; }
            set { lista_estudiantes = value; }

        }
    }
}
