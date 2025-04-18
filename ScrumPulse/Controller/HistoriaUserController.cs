using ScrumPulse.Models;

namespace ScrumPulse.Controller
{
    public class HistoriaUserController
    {
        public List<HistoriaUser> Backlog { get; private set; }

        public HistoriaUserController()
        {
            Backlog = new List<HistoriaUser>();
        }

        public void AddStory(HistoriaUser story)
        {
            Backlog.Add(story);
            Backlog = Backlog.OrderBy(s => s.Prioridad).ToList();
        }
    }
}
