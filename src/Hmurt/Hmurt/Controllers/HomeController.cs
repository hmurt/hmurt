using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Hmurt.Models;
using System.IO;
using System.Reflection;
using CommonMark;

namespace Hmurt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new ContentModel();

            using (StreamReader r = new StreamReader(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content/home.en.md")))
            {
                var markdown = r.ReadToEnd();
                model.HomeContent = CommonMarkConverter.Convert(markdown);
            }

            using (StreamReader r = new StreamReader(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content/cv.en.md")))
            {
                var markdown = r.ReadToEnd();
                model.CVContent = CommonMarkConverter.Convert(markdown);
            }

            using (StreamReader r = new StreamReader(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content/projects.en.md")))
            {
                var markdown = r.ReadToEnd();
                model.ProjectsContent = CommonMarkConverter.Convert(markdown);
            }

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
