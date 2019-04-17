using System;
using System.Collections.Generic;

namespace EjCombo.Repository.Models
{
    public partial class Agregado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Hamburguesaid { get; set; }

        public virtual Hamburguesa Hamburguesa { get; set; }
    }
}
