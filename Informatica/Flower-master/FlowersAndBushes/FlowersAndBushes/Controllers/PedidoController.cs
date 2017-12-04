using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace FlowersAndBushes.Controllers
{
    public class PedidoController : Controller
    {
        //
        // GET: /Pedido/
        public ActionResult Index()
        {
            if (Session["login"] != null)
            {
                DbEntityDataContext db = new DbEntityDataContext();

                var pedidos = from p in db.Pedidos select p;
                var usuarios = from u in db.Usuarios select u;
                
                ViewBag.usuarios = usuarios;

                return View(pedidos);
            }
            else
            {
                return Redirect("~/Cliente/Login");
            }
        }

        //
        // GET: /Pedido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: /Pedido/Crear
        public ActionResult Crear()
        {
            DbEntityDataContext db = new DbEntityDataContext();
            var productos = from p in db.Productos orderby p.Tipo select p;
            ViewBag.productos = productos;

            if (Session["login"] != null)
            {
                return View();
            }
            else
            {
                return Redirect("~/Cliente/Login");
            }
        }

        [HttpPost]
        public ActionResult Crear(FormCollection form)
        {
            DbEntityDataContext db = new DbEntityDataContext();
            var productos = from p in db.Productos orderby p.Tipo select p;
            ViewBag.productos = productos;

            Pedidos pedidos = new Pedidos();
            pedidos.fecha = DateTime.ParseExact(
                form["fecha"], 
                "yyyymmdd", 
                CultureInfo.InvariantCulture);
            pedidos.dimensionesJardin = form["dimensionesJardin"];
            pedidos.presupuesto = decimal.Parse(form["presupuesto"]);
            pedidos.comentarios = form["comentarios"];
            pedidos.usuario_id = (int)Session["id"];

            db.Pedidos.InsertOnSubmit(pedidos);
            db.SubmitChanges();

            foreach (Productos p in productos)
            {
                if (int.Parse(form[string.Concat("c", p.Id)]) != 0)
                {
                    PedidosDetalles pd = new PedidosDetalles();
                    pd.IdPedido = pedidos.Id;
                    pd.IdProducto = p.Id;
                    pd.Cantidad = int.Parse(form[string.Concat("c", p.Id)]);

                    db.PedidosDetalles.InsertOnSubmit(pd);
                    db.SubmitChanges();
                }
            }

            return Redirect(Url.Content("~/Pedido/Crear"));
        }

        //
        // GET: /Pedido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pedido/Edit/5
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
        // GET: /Pedido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pedido/Delete/5
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
