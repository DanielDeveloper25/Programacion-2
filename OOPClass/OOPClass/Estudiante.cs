using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass
{
    public class Estudiante : IMiembroDeLaComunidad
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public int Matricula { get; set; }
        public string Carrera { get; set; }
        
        public void estudiar() { }
    }
}
