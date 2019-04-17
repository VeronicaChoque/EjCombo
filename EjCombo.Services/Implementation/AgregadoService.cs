using EjCombo.Repository.Interface;
using EjCombo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Services.Implementation
{
    public class AgregadoService:IAgregadoService
    {
        private readonly IAgregadoRepository agregadoRepository;

        public AgregadoService(IAgregadoRepository agregadoRepository)
        {
            this.agregadoRepository = agregadoRepository;
        }
    }
}
