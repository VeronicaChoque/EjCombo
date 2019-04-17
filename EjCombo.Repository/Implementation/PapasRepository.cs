using EjCombo.Repository.Interface;
using EjCombo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Repository.Implementation
{
    public class PapasRepository : Repository<Papas>, IPapasRepository
    {
        public PapasRepository(DbContext context) : base(context)
        {
        }
    }
}
