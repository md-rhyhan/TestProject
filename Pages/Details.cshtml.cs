using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestProject.Pages
{
    public class DetailsModel : PageModel
    {
        public Student Student { get; set; }
        public void OnGet(int? id)
        {
            Student = Student.GetAllStudent().FirstOrDefault(x=>x.Id==id);
        }
    }
}
