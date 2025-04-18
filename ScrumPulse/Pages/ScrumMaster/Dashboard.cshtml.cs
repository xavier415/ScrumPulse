using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScrumPulse.Models;

namespace ScrumPulse.Pages.ScrumMaster
{
    public class DashboardModel : PageModel
    {
        public List<Sprint> Sprints { get; set; } = new();
        public void OnGet()
        {
            Sprints.Add(new Sprint { Nombre = "Sprint 1", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(14) });
        }
    }
}
