using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScrumPulse.Models;

namespace ScrumPulse.Pages.ProductOwner
{
    public class DashboardModel : PageModel
    {
        public List<HistoriaUser> Backlog { get; set; } = new();
        public void OnGet()
        {
            Backlog.Add(new HistoriaUser { Titulo = "Crear login", Descripcion = "Pantalla de login", Prioridad = 1, Tags = "Login, Seguridad" });
        }
    }
}
