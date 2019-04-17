using EjCombo.Repository.Interface;
using EjCombo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Repository.Implementation
{
    public class AgregadoRepository : Repository<Agregado>, IAgregadoRepository
    {
        public AgregadoRepository(DbContext context) : base(context)
        {
        }
    }
}
