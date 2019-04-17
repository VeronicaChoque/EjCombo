using EjCombo.Repository.Interface;
using EjCombo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Services.Implementation
{
    public class HamburguesaService:IHamburguesaService
    {
        private readonly IHamburguesaRepository hamburguesaRepository;

        public HamburguesaService(IHamburguesaRepository hamburguesaRepository)
        {
            this.hamburguesaRepository = hamburguesaRepository;
        }
    }
}
