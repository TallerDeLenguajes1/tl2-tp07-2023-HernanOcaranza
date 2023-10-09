using System.Text.Json;
using Tp7.Models;

namespace Tp7.Repositorio
{
    public class AccesoADatosJson
    {        
        private readonly string _nombreArchivo = "tareas.json";
        public List<Tarea> Obtener()
        {            
            var listaTareas = new List<Tarea>();
            if (File.Exists(_nombreArchivo))
            {
                var json = File.ReadAllText(_nombreArchivo);
                listaTareas = JsonSerializer.Deserialize<List<Tarea>>(json);
            }
            return listaTareas;
        }

        public void Guardar(List<Tarea> listaTareas)
        {            
            var contenido = JsonSerializer.Serialize(listaTareas);
            File.WriteAllText(_nombreArchivo, contenido);            
        }
    }
}