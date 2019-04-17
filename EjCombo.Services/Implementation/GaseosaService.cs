using EjCombo.Repository.Interface;
using EjCombo.Repository.Models;
using EjCombo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Services.Implementation
{
    public class GaseosaService:IGaseosaService
    {
        private readonly IGaseosaRepository gaseosaRepository;

        public GaseosaService(IGaseosaRepository gaseosaRepository)
        {
            this.gaseosaRepository = gaseosaRepository;
        }

        public IEnumerable<Gaseosa> TraerTodasLasGaseosas()
        {
            return gaseosaRepository.GetAll();
        }
    }
}
