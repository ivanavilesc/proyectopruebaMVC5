using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testAppRepo.Models;
namespace testAppRepo.Controllers
{
    public class TipoProductoController : Controller
    {
        private readonly CrudContext _context = new CrudContext();

        // GET: Employees  
        public ActionResult Index()
        {
            return View();
        }
    


    // GET: TipoProducto
    

        public ActionResult Create()
        {
           
            return View();

        }

        [HttpPost]
        public ActionResult Create(TIPOPRODUCTO objTipoProducto)
        {
            try
            {
                // TODO: Add insert logic here



                if (ModelState.IsValid)
                {
                    _context.TipoProducto.Add(objTipoProducto);
                    _context.SaveChanges();
                }
                return View(objTipoProducto);


                
                
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
    }
}