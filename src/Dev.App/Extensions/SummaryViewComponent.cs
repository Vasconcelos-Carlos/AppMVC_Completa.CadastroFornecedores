using Dev.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.App.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SummaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var noticacoes = await Task.FromResult(_notificador.ObterNotificacoes());
            noticacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));
            return View();
        }
    }
}
