using System.IO;
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
            var stampingImages = Directory.GetFiles(Server.MapPath(@"~/Images/stamping")).Select(x => string.Format("/Images/stamping/{0}", x.Split('\\').Last())).ToList();
            var galleryModel = new GalleryModel();
            galleryModel.Images = stampingImages;
            return View(galleryModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Models()
        {
            var stampingImages = Directory.GetFiles(Server.MapPath(@"~/Images/models")).Select(x => string.Format("/Images/models/{0}", x.Split('\\').Last())).ToList();
            
            var galleryModel = new GalleryModel();
            galleryModel.Images = stampingImages;
            return View(galleryModel);
        }

        public ActionResult Lighting()
        {
            var stampingImages = Directory.GetFiles(Server.MapPath(@"~/Images/lighting")).Select(x => string.Format("/Images/lighting/{0}", x.Split('\\').Last())).ToList();
            var galleryModel = new GalleryModel();
            galleryModel.Images = stampingImages;
            return View(galleryModel);
        }
    }
}
