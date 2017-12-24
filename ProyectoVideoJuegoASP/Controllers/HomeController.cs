using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoVideoJuegoASP.Controllers
{
    public class HomeController : Controller
    {
        byte[] imgperfil;
        Models.MacrowebEntities cnx;
        


        public HomeController()
        {
            cnx = new Models.MacrowebEntities();
            
        }


        public ActionResult Principal()
        {
            return View();
        }


        public ActionResult Guardar(int id, string nombre, string apellido, string username, string password, string email, string imgperfil,string sexo)
        {

            for (int x = 0; id <= 0; x++)
            {
                id++;
                ProyectoVideoJuegoASP.Models.USUARIO persona = new ProyectoVideoJuegoASP.Models.USUARIO()
                {

                    id = id,
                    nombre = nombre,
                    apellido = apellido,
                    username = username,
                    password = password,
                    email = email,
                    imgperfil = imgperfil,
                    sexo = sexo

                };

                cnx.USUARIO.Add(persona);
                cnx.SaveChanges();

            }
            return View("Lobby",listar());
        }


        public ActionResult Reporte(int id, int codigo, string nombre, string descripcion)
        {
            ProyectoVideoJuegoASP.Models.Reporte reporte = new ProyectoVideoJuegoASP.Models.Reporte()
            {
                id = id,
                codigo = codigo,
                nombre = nombre,
                descripcion = descripcion

            };
            cnx.Reporte.Add(reporte);
            cnx.SaveChanges();


            return View("Perfil",reporte);
        }

        public ActionResult Perfil(int id)
        {


            return View(cnx.USUARIO.Where(x => x.id == id).First());
        }


        private List<ProyectoVideoJuegoASP.Models.USUARIO> listar()
        {
            return cnx.USUARIO.ToList();
        }


        public ActionResult Lobby()
        {
            return View(listar());
        }
    }
}