using System;
using System.Collections.Generic;

namespace EjCombo.Repository.Models
{
    public partial class Hamburguesa
    {
        public Hamburguesa()
        {
            Agregado = new HashSet<Agregado>();
            Combo = new HashSet<Combo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Agregado> Agregado { get; set; }
        public virtual ICollection<Combo> Combo { get; set; }
    }
}
