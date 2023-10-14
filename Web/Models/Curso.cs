using System;
using System.Collections.Generic;

namespace Web.Models
{
    public partial class Curso
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; } = null!;
        public string DescripciónCurso { get; set; } = null!;
        public int DuraciónCurso { get; set; }
    }
}
