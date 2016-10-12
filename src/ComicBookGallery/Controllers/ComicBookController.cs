using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController: Controller
    {
        
        public ActionResult  Detail() {
            // ViewBag is a Razar type that can hold nay data type
            // to allow us to use them in the view folder.
            ViewBag.SeriesTitle = "The Amazing Spider-Man"; 
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
            "script: dan slott",
            "pencils: humberto ramos",
            "inks: victor olazaba",
            "colors: edgar delgado",
            "letters: chris eliopoulos"
            };
            return View();
        } 
    }
}