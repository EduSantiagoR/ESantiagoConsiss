using DL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }
        public string HabilidadPrimaria { get; set; }
        public string HabilidadSecundaria { get; set; }
        public int IdTipo { get; set; }
        public List<Persona> Personas { get; set; }
        public static List<Persona> GetAll()
        {
            List<Persona> personas =  new List<Persona>();
            try
            {
                using(DL.ESantiagoConsissEntities context = new DL.ESantiagoConsissEntities())
                {
                    var query = (from person in context.Persona
                                 select new
                                 {
                                     IdPersona = person.IdPersona,
                                     Nombre = person.Nombre,
                                     Direccion = person.Direccion,
                                     Correo = person.Correo,
                                     Edad = person.Edad,
                                     Habilidades = person.Habilidades,
                                     IdTipo = person.IdTipo,
                                 }).ToList();
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            Persona persona = new Persona();
                            persona.IdPersona = item.IdPersona;
                            persona.Nombre = item.Nombre;
                            persona.Direccion = item.Direccion;
                            persona.Correo = item.Correo;
                            persona.Edad = item.Edad;
                            string[] habilidades = item.Habilidades.Split('/');
                            persona.HabilidadPrimaria = habilidades[0];
                            persona.HabilidadSecundaria = habilidades[1];
                            persona.IdTipo = item.IdTipo;

                            personas.Add(persona);
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            { 
            }
            return personas;
        }
        public static Persona GetById(int idPersona)
        {
            Persona persona = new Persona();
            try
            {
                using (DL.ESantiagoConsissEntities context = new DL.ESantiagoConsissEntities())
                {
                    var query = (from person in context.Persona
                                 where person.IdPersona == idPersona
                                 select new
                                 {
                                     IdPersona = person.IdPersona,
                                     Nombre = person.Nombre,
                                     Direccion = person.Direccion,
                                     Correo = person.Correo,
                                     Edad = person.Edad,
                                     Habilidades = person.Habilidades,
                                     IdTipo = person.IdTipo,
                                 }).AsEnumerable().FirstOrDefault();
                    if (query != null)
                    {
                        persona.IdPersona = query.IdPersona;
                        persona.Nombre = query.Nombre;
                        persona.Direccion = query.Direccion;
                        persona.Correo = query.Correo;
                        persona.Edad = query.Edad;
                        string[] habilidades = query.Habilidades.Split('/');
                        persona.HabilidadPrimaria = habilidades[0];
                        persona.HabilidadSecundaria = habilidades[1];
                        persona.IdTipo = query.IdTipo;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return persona;
        }
        public static bool Add(Persona persona)
        {
            try
            {
                using(DL.ESantiagoConsissEntities context = new ESantiagoConsissEntities())
                {
                    int rowsAffected = context.PersonaABC("Add", persona.IdPersona, persona.Nombre, persona.Direccion, persona.Edad, persona.Correo, persona.HabilidadPrimaria, persona.HabilidadSecundaria);
                    return rowsAffected > 0? true: false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public static bool Update(Persona persona)
        {
            try
            {
                using (DL.ESantiagoConsissEntities context = new ESantiagoConsissEntities())
                {
                    int rowsAffected = context.PersonaABC("Update", persona.IdPersona, persona.Nombre, persona.Direccion, persona.Edad, persona.Correo, persona.HabilidadPrimaria, persona.HabilidadSecundaria);
                    return rowsAffected > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Delete(int idPersona)
        {
            try
            {
                using (DL.ESantiagoConsissEntities context = new ESantiagoConsissEntities())
                {
                    int rowsAffected = context.PersonaABC("Delete", idPersona, "", "", 0, "", "", "");
                    return rowsAffected > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}