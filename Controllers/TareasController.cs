using Microsoft.AspNetCore.Mvc;
using Tp7.Models;
using Tp7.Repositorio;

namespace Tp7.Controllers;

[ApiController]
[Route("[tareas]")]
public class TareasController : ControllerBase
{    
    public TareasController()
    {
        var accesoADatosJson = new AccesoADatosJson();
        var listaTareas = accesoADatosJson.Obtener();
        var tarea = new Tarea();
        listaTareas.Add(tarea);
        accesoADatosJson.Guardar(listaTareas);
    }    
}
