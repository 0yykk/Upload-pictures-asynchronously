using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Upload_pictures_asynchronously.Controllers
{
    public class FileOperationController : Controller
    {
        // GET: FileOperation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ImageUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessImgUpload()
        {
            var file = Request.Files["imgFile"];
            string path = "/Upload/" + Guid.NewGuid().ToString() + file.FileName;
            string savepath = Request.MapPath(path);
            file.SaveAs(savepath);
            return Content(path);
        }

    }
}