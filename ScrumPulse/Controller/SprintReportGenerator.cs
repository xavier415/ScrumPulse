using ScrumPulse.Models;
using QuestPDF.Fluent;


namespace ScrumPulse.Controller
{
    public class SprintReportGenerator
    {
        public void GenerateSprintReport(string filePath, List<TareaItem> completedTasks, List<string> impediments)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);
                    page.Header().Text("Sprint Report").FontSize(20).Bold();
                    page.Content().PaddingVertical(10).Column(col =>
                    {
                        col.Item().Text("Tarea Completada:").FontSize(14).Bold();
                        foreach (var task in completedTasks)
                            col.Item().Text($"- {task.Titulo}");

                        col.Item().PaddingTop(15).Text("Impedimientos:").FontSize(14).Bold();
                        foreach (var imp in impediments)
                            col.Item().Text($"- {imp}");
                    });
                    page.Footer().AlignCenter().Text("ScrumPulse 2025");
                });
            }).GeneratePdf(filePath);
        }
    }
}
