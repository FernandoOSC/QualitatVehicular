using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Entidades;
using Dominio.Repositorio;

namespace GenesisVehivular.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarTipoVehiculo()
        {
            General_BL bl = new General_BL();
            List<TipoVehiculoEntity> listado = bl.ListarTipoVehiculo_BL();
            return Json(listado);
        }

        public ActionResult ListarTipoUso()
        {
            General_BL bl = new General_BL();
            List<TipoUsoEntity> listado = bl.ListarTipoUso_BL();
            return Json(listado);
        }

        public ActionResult ListarMarcaVehiculo()
        {
            General_BL bl = new General_BL();
            List<MarcaVehiculoEntity> listado = bl.ListarMarcaVehiculo_BL();
            return Json(listado);
        }

        public ActionResult ListarModeloVehiculo(int id_marca)
        {
            General_BL bl = new General_BL();
            List<ModeloVehiculoEntity> listado = bl.ListarModeloVehiculo_BL(id_marca);
            return Json(listado);
        }

        public ActionResult ListarTipoDocumento()
        {
            General_BL bl = new General_BL();
            List<TipoDocumentoEntity> listado = bl.ListarTipoDocumento_BL();
            return Json(listado);
        }

        public ActionResult ListarNacionalidad()
        {
            General_BL bl = new General_BL();
            List<NacionalidadEntity> listado = bl.ListarNacionalidad_BL();
            return Json(listado);
        }

        public ActionResult ListarSexo()
        {
            General_BL bl = new General_BL();
            List<SexoEntity> listado = bl.ListarSexo_BL();
            return Json(listado);
        }

        public ActionResult ListarEstadoCivil()
        {
            General_BL bl = new General_BL();
            List<EstadoCivilEntity> listado = bl.ListarEstadoCivil_BL();
            return Json(listado);
        }

        public ActionResult ListarDepartamento()
        {
            General_BL bl = new General_BL();
            List<DepartamentoEntity> listado = bl.ListarDepartamento_BL();
            return Json(listado);
        }

        public ActionResult ListarProvincia(string vdepartamento)
        {
            General_BL bl = new General_BL();
            List<ProvinciaEntity> listado = bl.ListarProvincia_BL(vdepartamento);
            return Json(listado);
        }

        public ActionResult ListarDistrito(string vdepartamento, string vprovincia)
        {
            General_BL bl = new General_BL();
            List<DistritoEntity> listado = bl.ListarDistrito_BL(vdepartamento, vprovincia);
            return Json(listado);
        }

        public ActionResult ListarTipoVia()
        {
            General_BL bl = new General_BL();
            List<TipoViaEntity> listado = bl.ListarTipoVia_BL();
            return Json(listado);
        }

        public ActionResult ListarTipoPoliza()
        {
            General_BL bl = new General_BL();
            List<TipoPolizaEntity> listado = bl.ListarTipoPoliza_BL();
            return Json(listado);
        }

        public ActionResult RegistrarPoliza(
                int smidtablatipopoliza,
                string vplaca,
                int smidmodelo,
                int smaniofabrica,
                string vmotor,
                string svin,
                int smnroasiento,
                string vcolor,
                string desumaasegurada,
                int smidtablaclasevehiculo,
                string idnrodocumento,
                string vnombres,
                string vcelular,
                string vtelefono1,
                string vemail,
                string vreferencia,
                string vnumero,
                string vnombrevia,
                int smIdTipoVia,
                int smestadocivil,
                string vdepartamento,
                string vprovincia,
                string vdistrito,
                string dfechanac,
                int btsexo,
                string vapellidopat,
                string vapellidomat


            )
        {
            General_BL bl = new General_BL();
            List<RespuestaPost> listado = bl.RegistrarPoliza_BL(
                smidtablatipopoliza,
                vplaca,
                smidmodelo,
                smaniofabrica,
                vmotor,
                svin,
                smnroasiento,
                vcolor,
                desumaasegurada,
                smidtablaclasevehiculo,

                idnrodocumento,
                vnombres,
                vcelular,
                vtelefono1,
                vemail,
                vreferencia,
                vnumero,
                vnombrevia,
                smIdTipoVia,
                smestadocivil,
                vdepartamento,
                vprovincia,
                vdistrito,
                dfechanac,
                btsexo,
                vapellidopat,
                vapellidomat


                );
            return Json(listado);
        }










    }
}