using EjCombo.Repository.Interface;
using EjCombo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Services.Implementation
{
    public class PapasService:IPapasService
    {
        private readonly IPapasRepository papasRepository;

        public PapasService(IPapasRepository papasRepository)
        {
            this.papasRepository = papasRepository;
        }
    }
}
