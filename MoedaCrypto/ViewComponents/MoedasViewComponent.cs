using Microsoft.AspNetCore.Mvc;
using MoedaCrypto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoedaCrypto.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly MoedasContexto _moedasContexto;

        public MoedasViewComponent(MoedasContexto moedasContexto)
        {
            _moedasContexto = moedasContexto;
        }
        public async Task<IViewComponentResult> InvokeAsync()
            {
            //utilização de metodo para passar os dados para a view
            return View(await _moedasContexto.Moedas.ToListAsync());

            }
    }
}

