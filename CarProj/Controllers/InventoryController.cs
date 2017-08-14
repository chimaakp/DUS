using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarProj.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            Inventory model = new Inventory();            
            model.Warehouse.Add(new Models.Car{ Description = "hello world", Makemodel="VWagen", Mileage=67844});
            model.Warehouse.First().Pictures = "https://tse3.mm.bing.net/th?id=OIP.3Hbmbo-L6hiSctqqgdk3ZgEsCb&pid=15.1";
            model.Warehouse.Add(new Models.Car { Description = "hello earth", Pictures= "http://static.cargurus.com/images/site/2016/04/09/20/56/2016_ford_mustang_gt_premium-pic-7563060132329573226-1600x1200.png", Makemodel="Stang", Mileage=90 });
            model.Warehouse.Add(new Models.Car { Description = "wizard", Pictures = "http://www.pngmart.com/files/4/Car-PNG-Pic.png", Makemodel="Audi", Mileage=3000 });
           
            return View(model);
        }
    }
}