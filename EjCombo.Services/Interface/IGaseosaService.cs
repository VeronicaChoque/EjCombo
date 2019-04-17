using EjCombo.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Services.Interface
{
    public interface IGaseosaService
    {
        IEnumerable<Gaseosa> TraerTodasLasGaseosas();
    }
}
