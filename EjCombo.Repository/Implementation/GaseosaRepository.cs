using EjCombo.Repository.Interface;
using EjCombo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Repository.Implementation
{
    public class GaseosaRepository : Repository<Gaseosa>, IGaseosaRepository
    {
        public GaseosaRepository(DbContext context) : base(context)
        {
        }
    }
}
