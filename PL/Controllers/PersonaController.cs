using PL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace PL.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult GetAll()
        {
            Persona persona = new Persona();
            persona.Personas = Persona.GetAll();
            return View(persona);
        }
        public ActionResult Form(int? idPersona)
        {
            Persona persona = new Persona();
            if (idPersona != null)
            {
                persona = Persona.GetById(idPersona.Value);
            }
            return View(persona);
        }
        [HttpPost]
        public ActionResult Form(Persona persona)
        {
            if (persona.IdPersona == 0)
            {
                bool result = Persona.Add(persona);
                ViewBag.Mensaje = result ? "Persona agregada correctamente" : "Error al agregar persona";
            }
            else
            {
                bool result = Persona.Update(persona);
                ViewBag.Mensaje = result ? "Persona actualizada correctamente" : "Error al actualizar persona";
            }
            return PartialView("Modal");
        }
        public ActionResult Delete(int idPersona)
        {
            bool result = Persona.Delete(idPersona);
            ViewBag.Mensaje = result ? "Persona eliminada correctamente" : "Error al eliminar persona";
            return PartialView("Modal");
        }
        public ActionResult LeerXML()
        {
            XmlDocument xmlDocument = new XmlDocument();
            string rutaArchivoXML = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Persona", "Noticia.xml");
            xmlDocument.Load(rutaArchivoXML);
            XmlNode root = xmlDocument.DocumentElement; //crear etiqueta principal o raíz

            XmlDocument xmlResult = new XmlDocument();

            XmlElement info = xmlResult.CreateElement("info");
            XmlElement podcast = xmlResult.CreateElement("podcast");

            foreach (XmlNode nodo in root.ChildNodes) //Leer nodos o etiquetas
            {
                if(nodo.Attributes != null)
                {
                    foreach (XmlAttribute attr in nodo.Attributes)
                    {
                        AgregarAtributo(xmlResult, podcast, attr.Name, attr.Value);
                    }
                }
                foreach (XmlNode hijo in nodo.ChildNodes)
                {
                    if (hijo is XmlElement)
                    {
                        // Acceder al contenido de la etiqueta
                        string nombreEtiqueta = hijo.Name;
                        string contenidoEtiqueta = hijo.InnerText;

                        if (nombreEtiqueta == "categoria" || nombreEtiqueta == "titulo" || nombreEtiqueta == "resumen" || nombreEtiqueta == "prevurl" || nombreEtiqueta == "url")
                        {
                            XmlElement nuevo = xmlResult.CreateElement(nombreEtiqueta);
                            nuevo.InnerText = contenidoEtiqueta;
                            podcast.AppendChild(nuevo);
                        }
                        if(nombreEtiqueta == "libre"||nombreEtiqueta == "id" || nombreEtiqueta == "is3idfp" || nombreEtiqueta == "idaudio")
                        {
                            AgregarAtributo(xmlResult, podcast , nombreEtiqueta, contenidoEtiqueta);
                        }
                    }
                }
            }
            XmlDeclaration xmlDeclaration = xmlResult.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            xmlResult.AppendChild(xmlDeclaration);
            info.AppendChild(podcast);
            xmlResult.AppendChild(info);

            xmlResult.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Persona", "Podcast.xml"));

            return View();
        }
        static void AgregarAtributo(XmlDocument xmlDoc, XmlElement elemento, string nombreAtributo, string valorAtributo)
        {
            // Crear el atributo
            XmlAttribute atributo = xmlDoc.CreateAttribute(nombreAtributo);

            // Establecer el valor del atributo
            atributo.Value = valorAtributo;

            // Agregar el atributo al elemento
            elemento.Attributes.Append(atributo);
        }
    }
}