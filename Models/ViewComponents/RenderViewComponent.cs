using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace MyWebAPP.Models.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> MenuItems;

        public RenderViewComponent()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem() { Id = 1, Name = "Branches", Link = "Branches/List" },
                new MenuItem() { Id = 2, Name = "Students", Link = "Students/List" },
                new MenuItem() { Id = 3, Name = "Subjects", Link = "Subject/List" },
                new MenuItem() { Id = 4, Name = "Courses", Link = "Courses/List" }
            };
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}