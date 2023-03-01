using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEM_MATRICULAS
{
    class Estudiante
    {
        private string nombre_estudiante;
        List<Curso> lista_cursos = new List<Curso>();


        public string _nombre_estudiante
        {
            get { return nombre_estudiante; }
            set { nombre_estudiante = value;}

        }

        public List<Curso> _lista_cursos
        {
            get { return lista_cursos; }
            set { lista_cursos = value; }

        }
    }
}
