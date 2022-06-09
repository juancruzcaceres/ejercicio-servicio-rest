using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        private static List<Animal> ListaAnimales = new List<Animal>()
        {
            new Animal() { ID=0, Nombre="Gato", Especie="Felino", FechaCreacion=DateTime.Today, FechaModificacion=DateTime.Today, Eliminado=false }
        };

        public Animal Alta(string nombre, string especie)
        {
            Animal animal = new Animal();
            animal.ID = ListaAnimales.Count() + 1;
            animal.Nombre = nombre;
            animal.Especie = especie;
            animal.FechaCreacion = DateTime.Today;
            animal.FechaModificacion = DateTime.Today;
            animal.Eliminado = false;
            ListaAnimales.Add(animal);
            return animal;
        }

        public Animal Baja(int id)
        {
            Animal animal = ListaAnimales.Find(x => x.ID == id);
            if (animal != null)
                animal.Eliminado = true;
            return animal;
        }

        public Animal Modificar(int id, string nuevoNombre, string nuevaEspecie)
        {
            Animal animal = ListaAnimales.Find(x => x.ID == id);
            if (animal != null)
            {
                animal.Nombre = nuevoNombre;
                animal.Especie = nuevaEspecie;
                animal.FechaModificacion = DateTime.Today;
            }
            return animal;
        }

        public Animal ObtenerAnimal(int id)
        {
            return ListaAnimales.Find(x => x.ID == id);
        }

        public List<Animal> ObtenerAnimales()
        {
            return ListaAnimales;
        }
    }
}
