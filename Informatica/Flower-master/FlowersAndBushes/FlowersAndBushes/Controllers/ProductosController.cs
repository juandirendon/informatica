using FlowersAndBushes.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowersAndBushes.Controllers
{
    public class ProductosController : Controller
    {
 
        public ActionResult Index()
        {
            DbEntityDataContext db = new DbEntityDataContext();
            List<Producto> productos = new List<Producto>();
            var dbProductos = from p in db.Productos select p;

            foreach (Productos p in dbProductos)
            {
                Producto producto = new Producto();
                producto.Id = p.Id;
                producto.Nombre = p.Nombre;
                producto.Precio = (decimal)p.Precio;
                producto.Tipo = (int)p.Tipo;
                producto.Imagen = p.Imagen;

                productos.Add(producto);
            }

            if (Session["login"] != null)
            {
                return View(productos);
            }
            else
            {
                return Redirect("~/Cliente/Login");
            }

        }

        public ActionResult Crear()
        {
            if (Session["login"] != null)
            {
                return View();
            }
            else
            {
                return Redirect("~/Cliente/Login");
            }
        }

        //
        // POST: /Productos/Crear
        [HttpPost]
        public ActionResult Crear(HttpPostedFileBase file, Producto producto)
        {
            if (ModelState.IsValid)
            {
                // Guardar imágen
                var name = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                var path = "";
                if (file != null)
                {
                    if (file.ContentLength > 0)
                    {
                        if (Path.GetExtension(file.FileName).ToLower()==".jpg" ||
                            Path.GetExtension(file.FileName).ToLower() == ".png" ||
                            Path.GetExtension(file.FileName).ToLower() == ".gif" ||
                            Path.GetExtension(file.FileName).ToLower() == ".jpeg")
                        {
                            var nameImage = String.Concat(name, Path.GetExtension(file.FileName).ToLower());
                            path = Path.Combine(Server.MapPath("~/Content/Images"), 
                                nameImage);
                            file.SaveAs(path);

                            DbEntityDataContext db = new DbEntityDataContext();
                            Productos productos = new Productos();

                            productos.Nombre = producto.Nombre;
                            productos.Tipo = producto.Tipo;
                            productos.Precio = producto.Precio;
                            productos.Imagen = nameImage;

                            db.Productos.InsertOnSubmit(productos);
                            db.SubmitChanges();

                            return Redirect(Url.Content("~/Productos"));
                        }
                    }
                }
                
            }
            return View(producto);
        }

        //
        // GET: /Productos/Edit/5
        public ActionResult Edit(int id)
        {
            DbEntityDataContext db = new DbEntityDataContext();
            var prod = (from p in db.Productos where p.Id == id select p).First();
            var producto = new Producto();

            producto.Id = prod.Id;
            producto.Nombre = prod.Nombre;
            producto.Precio = (Decimal)prod.Precio;
            producto.Tipo = (int)prod.Tipo;
            producto.Imagen = prod.Imagen;

            if (Session["login"] != null)
            {
                return View(producto);
            }
            else
            {
                return Redirect("~/Cliente/Login");
            }
        }

        //
        // POST: /Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HttpPostedFileBase file, Producto producto)
        {
            if (ModelState.IsValid)
            {
                DbEntityDataContext db = new DbEntityDataContext();
                Productos productos = (from p in db.Productos where p.Id == id select p).First();

                // Guardar imágen
                var name = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                var path = "";
                if (file != null)
                {
                    if (file.ContentLength > 0)
                    {
                        if (Path.GetExtension(file.FileName).ToLower() == ".jpg" ||
                            Path.GetExtension(file.FileName).ToLower() == ".png" ||
                            Path.GetExtension(file.FileName).ToLower() == ".gif" ||
                            Path.GetExtension(file.FileName).ToLower() == ".jpeg")
                        {
                            var nameImage = String.Concat(name, Path.GetExtension(file.FileName).ToLower());
                            path = Path.Combine(Server.MapPath("~/Content/Images"),
                                nameImage);
                            file.SaveAs(path);
                            
                            productos.Nombre = producto.Nombre;
                            productos.Tipo = producto.Tipo;
                            productos.Precio = producto.Precio;
                            productos.Imagen = nameImage;

                            db.SubmitChanges();
                            return Redirect(Url.Content("~/Productos"));
                        }
                    }
                } 
                else
                {
                    productos.Nombre = producto.Nombre;
                    productos.Tipo = producto.Tipo;
                    productos.Precio = producto.Precio;

                    db.SubmitChanges();
                    return Redirect(Url.Content("~/Productos"));
                }

            }
            return View(producto);
        }

        //
        // GET: /Productos/Delete/5
        public ActionResult Delete(int id)
        {
            DbEntityDataContext db = new DbEntityDataContext();
            Productos productos = (from p in db.Productos where p.Id == id select p).First();

            db.Productos.DeleteOnSubmit(productos);
            db.SubmitChanges();

            return Redirect(Url.Content("~/Productos"));
        }

    }
}
