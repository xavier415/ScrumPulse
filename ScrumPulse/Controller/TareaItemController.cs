using ScrumPulse.Models;

namespace ScrumPulse.Controller
{
    public class TareaItemController
    {
        public List<TareaItem> tarea { get; private set; }

        public TareaItemController()
        {
            tarea = new List<TareaItem>
            {
                new TareaItem { Titulo = "Iniciar sesión", Estado = "Pendiente" },
                new TareaItem { Titulo = "Diseño de interfaz de usuario", Estado = "En Progreso" },
                new TareaItem { Titulo= "Fix Bug #5", Estado = "Hecho" }
            };
        }

        public void UpdateState(TareaItem task, string newState)
        {
            task.Estado = newState;
        }
    }
}
