using System;
using System.Collections.Generic;

namespace EjCombo.Repository.Models
{
    public partial class Combo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Hamburguesaid { get; set; }
        public int Gaseosaid { get; set; }
        public int Papasid { get; set; }

        public virtual Gaseosa Gaseosa { get; set; }
        public virtual Hamburguesa Hamburguesa { get; set; }
        public virtual Papas Papas { get; set; }
    }
}
