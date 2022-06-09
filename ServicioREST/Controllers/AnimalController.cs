using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using Logica;

namespace ServicioREST.Controllers
{
    public class AnimalController : ApiController
    {
      
        public Animal Get(int id)
        {
            Principal principal = new Principal();
            return principal.ObtenerAnimal(id);
        }

        public List<Animal> Get()
        {
            Principal principal = new Principal();
            return principal.ObtenerAnimales();
        }

        public Animal Post(string nombre, string especie)
        {
            Principal principal = new Principal();
            return principal.Alta(nombre, especie);
        }

        public Animal Put(int id, string nuevoNombre, string nuevaEspecie)
        {
            Principal principal = new Principal();
            return principal.Modificar(id, nuevoNombre, nuevaEspecie);
            
        }

        public Animal Delete(int id)
        {
            Principal principal = new Principal();
            return principal.Baja(id);
        }

    }
}
