using EjCombo.Repository.Interface;
using EjCombo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Services.Implementation
{
    public class ComboService : IComboService
    {
        private readonly IComboRepository  comboRepository;

        public ComboService(IComboRepository comboRepository)
        {
            this.comboRepository = comboRepository;
        }
    }
}
