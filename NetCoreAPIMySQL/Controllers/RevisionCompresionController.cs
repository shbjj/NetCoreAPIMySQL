using Microsoft.AspNetCore.Mvc;
using NetCoreAPIMySQL.Model;

namespace NetCoreAPIMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevisionCompresionController : ControllerBase
    {
        public IActionResult Prueba(Model.Compresion.PlacaBase datosEntrada)
        {

            //Crear el Ancla
            Ancla ancla = new Ancla(datosEntrada.AnchoPropuesto, datosEntrada.Perfil.Centroide, datosEntrada.Ancla.DiametroAncla);
            ancla.CantidadDeAnclas = datosEntrada.Ancla.CantidadDeAnclas;
            ancla.DiametroAncla = datosEntrada.Ancla.DiametroAncla;
            ancla.DistanciaBordeRecortadoDet = datosEntrada.Ancla.DistanciaBordeRecortadoDet;
            //Crear el perfil
            Perfil perfil = datosEntrada.Perfil;

            //Crear Zona de Revision 1
            Model.Compresion.ZonaRevision1 zonaRevision1 = new Model.Compresion.ZonaRevision1();
            zonaRevision1._AnchoPropuesto = datosEntrada.AnchoPropuesto;
            zonaRevision1._Centroide = datosEntrada.Perfil.Centroide;
            zonaRevision1._CompresionMaxima = datosEntrada.CompresionMax;
            zonaRevision1._AreaPlaca = datosEntrada.AreaPlaca;
            //Espesor de placa definitivo...
            zonaRevision1._EspPlacaPorTensión = datosEntrada.EspPlacaPorTensión;
            zonaRevision1._AceroPlacaFy = datosEntrada.AceroPlaca_Fy;

            //Crear Zona de Revison 2
            Model.Compresion.ZonaRevision2 zonaRevision2 = new Model.Compresion.ZonaRevision2();
            zonaRevision2._AnchoPropuesto = datosEntrada.AnchoPropuesto;
            zonaRevision2._Lado = datosEntrada.Perfil.Lado;
            zonaRevision2._Centroide = datosEntrada.Perfil.Centroide;
            zonaRevision2._CompresionMaxima = datosEntrada.CompresionMax;
            zonaRevision2._AreaPlaca = datosEntrada.AreaPlaca;
            //Espesor de placa definitivo...
            zonaRevision2._EspPlacaPorTensión = datosEntrada.EspPlacaPorTensión;
            zonaRevision2._AceroPlacaFy = datosEntrada.AceroPlaca_Fy;

            //Crear Zona de Revision 3
            Model.Compresion.ZonaRevision3 zonaRevision3 = new Model.Compresion.ZonaRevision3();
            zonaRevision3._AnchoPropuesto = datosEntrada.AnchoPropuesto;
            zonaRevision3._Lado = datosEntrada.Perfil.Lado;
            zonaRevision3._Centroide = datosEntrada.Perfil.Centroide;
            zonaRevision3._CompresionMaxima = datosEntrada.CompresionMax;
            zonaRevision3._AreaPlaca = datosEntrada.AreaPlaca;
            //Espesor de placa definitivo...
            zonaRevision3._EspPlacaPorTensión = datosEntrada.EspPlacaPorTensión;
            zonaRevision3._AceroPlacaFy = datosEntrada.AceroPlaca_Fy;

            //Crear Placa base de compresion
            Model.Compresion.PlacaBase placaBase = new Model.Compresion.PlacaBase();
            placaBase = datosEntrada;
            placaBase.Perfil = perfil;
            placaBase.Ancla = ancla;
            placaBase.ZonaRevision1 = zonaRevision1;
            placaBase.ZonaRevision2 = zonaRevision2;
            placaBase.ZonaRevision3 = zonaRevision3;


            return Ok(placaBase);
        }
    }
}
