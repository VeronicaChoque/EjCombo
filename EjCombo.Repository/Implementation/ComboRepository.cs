using EjCombo.Repository.Interface;
using EjCombo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Repository.Implementation
{
    public class ComboRepository : Repository<Combo>, IComboRepository
    {
        public ComboRepository(DbContext context) : base(context)
        {
        }
    }
}
