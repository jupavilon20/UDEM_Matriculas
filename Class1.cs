using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEM_MATRICULAS
{
    internal class Profesor
    {
        private string nombre_profesor;
        List<Curso> Cursos_profesor = new List<Curso>();

        public string _nombre_profesor
        {
            get { return nombre_profesor; }
            set { nombre_profesor = value; }

        }

        public List<Curso> _Cursos_profesor
        {
            get { return Cursos_profesor; }
            set { Cursos_profesor = value; }

        }
    }
}
