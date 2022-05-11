using Microsoft.AspNetCore.Mvc;

namespace NetCoreAPIMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabeColumnaController : ControllerBase
    {
        public IActionResult CalcularTrabeColumna(Model.TrabeColumna.TrabeColumna datosEntrada)
        {
            //Crear el objeto de tipo TrabeColumna
            Model.TrabeColumna.TrabeColumna trabeColumna = datosEntrada;
            //Asignarle los valores a Tension
            trabeColumna.Tension = new Model.TrabeColumna.Tension();
            trabeColumna.Tension._a = datosEntrada.DimensionesPlaca.A;
            trabeColumna.Tension._espesor = datosEntrada.DimensionesPlaca.Espesor;
            trabeColumna.Tension._fy = datosEntrada.Perfil.Fy;
            trabeColumna.Tension._fu = datosEntrada.Perfil.Fu;
            trabeColumna.Tension._diametro = datosEntrada.Tornillo.Diametro;
            trabeColumna.Tension._noTornillos = datosEntrada.NoTornillos;
            //Asignarle los valores a Cortante
            trabeColumna.Cortante = new Model.TrabeColumna.Cortante();
            trabeColumna.Cortante._ag = trabeColumna.Tension.Ag;
            trabeColumna.Cortante._ae = trabeColumna.Tension.Ae;
            trabeColumna.Cortante._fy = trabeColumna.Perfil.Fy;
            trabeColumna.Cortante._fu = trabeColumna.Perfil.Fu;
            //Asignarle los valores a BloqueDeCortante
            trabeColumna.BloqueDeCortante._espesorPerfil = trabeColumna.Perfil.Espesor;
            trabeColumna.BloqueDeCortante._espesorPlaca = trabeColumna.DimensionesPlaca.Espesor;
            trabeColumna.BloqueDeCortante._dimensionPerfil = trabeColumna.Perfil.Dimension;
            trabeColumna.BloqueDeCortante._noTornillos = trabeColumna.NoTornillos;
            trabeColumna.BloqueDeCortante._gramil = trabeColumna.Perfil.Gramil;
            trabeColumna.BloqueDeCortante._fy = trabeColumna.Perfil.Fy;
            trabeColumna.BloqueDeCortante._fu = trabeColumna.Perfil.Fu;
            trabeColumna.BloqueDeCortante._Ag = trabeColumna.Tension.Ag;
            //Asignarle los valores a Compresion
            trabeColumna.Compresion = new Model.TrabeColumna.Compresion();
            trabeColumna.Compresion._bPlaca = trabeColumna.DimensionesPlaca.B;
            trabeColumna.Compresion._espesorPlaca = trabeColumna.DimensionesPlaca.Espesor;
            trabeColumna.Compresion._fy = trabeColumna.Perfil.Fy;

            return Ok(trabeColumna);
        }
    }
}
