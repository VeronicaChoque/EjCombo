using System;
using System.Collections.Generic;

namespace EjCombo.Repository.Models
{
    public partial class Papas
    {
        public Papas()
        {
            Combo = new HashSet<Combo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tamanio { get; set; }

        public virtual ICollection<Combo> Combo { get; set; }
    }
}
