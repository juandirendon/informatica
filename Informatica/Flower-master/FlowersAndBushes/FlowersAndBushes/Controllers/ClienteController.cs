using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlowersAndBushes.Models;

namespace FlowersAndBushes.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cliente/Crear
        public ActionResult Crear()
        {
            return View();
        }

        //
        // POST: /Cliente/Create
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            // Validar si es un modelo valido
            if (ModelState.IsValid)
            {
                // Obtener contexto para transacciones en base de datos
                DbEntityDataContext db = new DbEntityDataContext();
                Usuarios usuarios = new Usuarios();

                // Setear valores en el objeto de tipo Base de datos desde el modelo
                usuarios.tipoDocumento = model.tipoDocumento;
                usuarios.numeroDocumento = model.numeroDocumento;
                usuarios.primerNombre = model.primerNombre;
                usuarios.segundoNombre = model.segundoNombre;
                usuarios.primerApellido = model.primerApellido;
                usuarios.segundoApellido = model.segundoApellido;
                usuarios.contrasena = model.contrasena;
                usuarios.sexo = model.sexo;
                usuarios.correo = model.correo;
                usuarios.celular = model.celular;
                usuarios.telefono = model.telefono;

                // Buscar registros existentes en la base de datos
                var usuario = from x in db.Usuarios where x.correo == model.correo select x;

                var id = 0;

                if (usuario.Count() == 0)
                {
                    // Si no existe el registro se crea uno nuevo
                    db.Usuarios.InsertOnSubmit(usuarios);
                    db.SubmitChanges();

                    id = usuarios.Id;
                }
                else
                {
                    // si ya existe el registro se actualizan los datos
                    var tmpUsuarios = usuario.First();

                    tmpUsuarios.tipoDocumento = model.tipoDocumento;
                    tmpUsuarios.numeroDocumento = model.numeroDocumento;
                    tmpUsuarios.primerNombre = model.primerNombre;
                    tmpUsuarios.segundoNombre = model.segundoNombre;
                    tmpUsuarios.primerApellido = model.primerApellido;
                    tmpUsuarios.segundoApellido = model.segundoApellido;
                    tmpUsuarios.contrasena = model.contrasena;
                    tmpUsuarios.sexo = model.sexo;
                    tmpUsuarios.correo = model.correo;
                    tmpUsuarios.celular = model.celular;
                    tmpUsuarios.telefono = model.telefono;

                    db.SubmitChanges();

                    id = tmpUsuarios.Id;
                }

                // Se almacenan los datos de usuario en sesion
                Session.Add("login", true);
                Session.Add("id", id);
                Session.Add("correo", model.correo);
                Session.Add("contrasena", model.contrasena);

                return Redirect(Url.Content("~/"));
            }

            return View(model);
        }

        //
        //  GET: /Cliente/login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario model)
        {
            // Validar si es un modelo válido
            if (ModelState.IsValid)
            {
                // Validar que no esten vacios los campos 
                if (model.correo != null && model.contrasena != null)
                {

                    // Obtener contexto para transacciones en base de datos
                    DbEntityDataContext db = new DbEntityDataContext();

                    // Validar los datos 
                    var usuario = from x in db.Usuarios
                                   where x.correo == model.correo
                                   && x.contrasena == model.contrasena
                                   select x;
                    if (usuario.Count() > 0)
                    {
                        // Se almacenan los datos de usuario en sesion
                        Session.Add("login", true);
                        Session.Add("id", usuario.First().Id);
                        Session.Add("correo", model.correo);
                        Session.Add("contrasena", model.contrasena);

                        return Redirect(Url.Content("~/"));
                    }
                    else
                    {
                        ViewBag.Message = "El usuario no se encuentra registrado";
                    }
                }
                else
                {
                    ViewBag.Message = "Ingrese un usuario y una contraseña";
                }
            }
            return View(model);
        }

        //
        // GET: /Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cliente/Edit/5
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
        // GET: /Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cliente/Delete/5
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
