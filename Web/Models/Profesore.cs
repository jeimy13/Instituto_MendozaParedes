﻿using System;
using System.Collections.Generic;

namespace Web.Models
{
    public partial class Profesore
    {
        public int IdProfesor { get; set; }
        public string NombreProfesor { get; set; } = null!;
        public string EspecialidadProfesor { get; set; } = null!;
    }
}
