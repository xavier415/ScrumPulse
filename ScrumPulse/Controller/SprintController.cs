using ScrumPulse.Models;

namespace ScrumPulse.Controller
{
    public class SprintController
    {
        public List<Sprint> Sprints { get; private set; }

        public SprintController()
        {
            Sprints = new List<Sprint>();
        }

        public string AddSprint(Sprint sprint)
        {
            if (sprint.StartDate >= sprint.EndDate)
                return "La fecha de inicio debe ser anterior a la fecha de finalización.";

            Sprints.Add(sprint);
            return "Sprint agregado exitosamente.";
        }
    }
}
