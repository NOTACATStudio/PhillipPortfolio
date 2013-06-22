using System.IO;
using System.Net.Mime;
using System.Web.Mvc;
using System.Linq;
using PhillipPortfolio.Models;

namespace PhillipPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Stamping");
        }

        public ActionResult Stamping()
        {
            var images = Directory.GetFiles(Server.MapPath(@"~/Images/stamping")).Select(x => string.Format("/Images/stamping/{0}", x.Split('\\').Last())).ToList();
            var galleryModel = new GalleryModel();
            galleryModel.Images = images;
            return View(galleryModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Models()
        {
            var images = Directory.GetFiles(Server.MapPath(@"~/Images/models")).Select(x => string.Format("/Images/models/{0}", x.Split('\\').Last())).ToList();
            
            var galleryModel = new GalleryModel();
            galleryModel.Images = images;
            return View(galleryModel);
        }

        public ActionResult Lighting()
        {
            var images = Directory.GetFiles(Server.MapPath(@"~/Images/lighting")).Select(x => string.Format("/Images/lighting/{0}", x.Split('\\').Last())).ToList();
            var galleryModel = new GalleryModel();
            galleryModel.Images = images;
            return View(galleryModel);
        }

        public ActionResult DownloadResume()
        {
            var resumePath = Url.Content("~/Content/resume_phillipbailey.pdf");

            return File(resumePath, "application/pdf", "resume_phillipbailey.pdf");
        }
    }
}
