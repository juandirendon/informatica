using FlowersAndBushes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowersAndBushes.Controllers
{
    public class ProductosController : Controller
    {
        public static Datos.FlowersAndBushesContext contexto = new Datos.FlowersAndBushesContext();
        
        public ActionResult Index()
        {
            List<Producto> productos = new List<Producto>();
            /*List<Producto> productos = contexto.Producto.OrderBy(p => p.IdProducto).Select(p => new Producto()

            {
                Nombre = p.Nombre,
                TipoFlores = p.TipoFlores,
                FamiliaPertenece = p.FamiliaPertenece,
                TemporadaFloración = p.TemporadaFloración,
                TemporadaPlantación= p.TemporadaPlantación,


                 
            }).ToList();
            */

            return View(productos);

        }


        //
        // GET: /Productos/Crear
        public ActionResult Crear()
        {
             Producto producto = new Producto();
             var tipoHoja = contexto.TipoHoja.Select(t => new TipoHoja() { IdTipoHoja = t.IdTipoHoja, Nombre = t.Nombre }).ToList();
            

            ViewBag.TipoHoja =
                    tipoHoja.Select(x => new SelectListItem
                    {
                        Text = x.Nombre,
                        Value = x.IdTipoHoja.ToString()
                    });
            return View(producto);
        }

        //
        // GET: /Productos/Crear
        public ActionResult Create()
        {
           
            return View();
        }

        //
        // POST: /Productos/Crear
        [HttpPost]
        public JsonResult Crear(Producto producto)
        {
            try
            {
                //productos.Add(producto);
                var json = Json(new { mensaje = "" });
                return json;
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message });
                            
            }
        }

        //
        // GET: /Productos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Productos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Productos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
