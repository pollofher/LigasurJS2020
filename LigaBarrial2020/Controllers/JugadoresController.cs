using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LigaBarrial2020.Models;

namespace LigaBarrial2020.Controllers
{
    public class JugadoresController : Controller
    {
        LigaBarrialEntities db = new LigaBarrialEntities();
        public ActionResult Index()
        {
            List<Equipo> JugadoryEquipo = db.Equipo.ToList();
            return View(JugadoryEquipo);
        }
        public ActionResult SaveOrder(string nom_equipo, String colores,DateTime fundacion,string Escudo,string serie,string Estado,int id_dirigente, Jugador[] jugador)
        {
            string result = "Error! Jugadores no están agregados!";
            if (nom_equipo != null && colores != null && fundacion != null && Escudo != null && serie != null && Estado != null && id_dirigente != 0 && jugador != null)
            {
                var EquipoId = Guid.NewGuid();
                Equipo model = new Equipo();
                model.equipoId = EquipoId;
                model.nom_equipo = nom_equipo;
                model.colores = colores;
                model.fundacion = DateTime.Now;
                //model.Escudo = Escudo;
                //model.Serie = serie;
                //model.Estado = Estado;
                //model.id_dirigente = id_dirigente;
                db.Equipo.Add(model);

                foreach (var item in jugador)
                {
                    var jugadorId = Guid.NewGuid();
                    Jugador j = new Jugador();
                    j.JugadorId = jugadorId;
                    j.cedula = item.cedula;
                    j.nom_jugador = item.nom_jugador;
                    j.apelli_jugador = item.apelli_jugador;
                    j.CARNET = item.CARNET;
                    j.fechaNacimiento = item.fechaNacimiento;
                    j.fotografia = item.fotografia;
                    j.afiliacion = item.afiliacion;
                    j.estadocivil = item.estadocivil;
                    j.instruccion = item.instruccion;
                    j.profesion = item.profesion;
                    j.provincia = item.provincia;
                    j.parroquia = item.parroquia;
                    j.EquipoId = EquipoId;
                    db.Jugador.Add(j);
                }
                db.SaveChanges();
                result = "Success! Jugadores completos!";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}