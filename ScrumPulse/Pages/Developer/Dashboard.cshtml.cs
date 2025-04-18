using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScrumPulse.Models;

namespace ScrumPulse.Pages.Developer
{
    public class DashboardModel : PageModel
    {
        public List<TareaItem> Tareas { get; set; } = new();
        public void OnGet()
        {
            Tareas.Add(new TareaItem { Titulo = "Implementar API", Estado = "In Progress" });
        }
    }
}
