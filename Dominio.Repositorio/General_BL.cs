using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Infraestrutura.Data.SqlServer;

namespace Dominio.Repositorio
{
    public class General_BL
    {

        General_DAL dal = new General_DAL();

//***************************************************************************************************************************************
//REGISTRO POLIZA *******************************************************************************************************************
//***************************************************************************************************************************************


        //Listar Tipo Vehiculo
        public List<TipoVehiculoEntity> ListarTipoVehiculo_BL()
        {
            return dal.ListarTipoVehiculo_DAL();
        }

        //Listar Tipo Uso
        public List<TipoUsoEntity> ListarTipoUso_BL()
        {
            return dal.ListarTipoUso_DAL();
        }

        //Listar Marca Vehiculo
        public List<MarcaVehiculoEntity> ListarMarcaVehiculo_BL()
        {
            return dal.ListarMarcaVehiculo_DAL();
        }

        //Listar Modelo Vehiculo
        public List<ModeloVehiculoEntity> ListarModeloVehiculo_BL(int id_marca)
        {
            return dal.ListarModeloVehiculo_DAL(id_marca);
        }

        //Listar Modelo Vehiculo
        public List<TipoDocumentoEntity> ListarTipoDocumento_BL()
        {
            return dal.ListarTipoDocumento_DAL();
        }

        //Listar Modelo Vehiculo
        public List<NacionalidadEntity> ListarNacionalidad_BL()
        {
            return dal.ListarNacionalidad_DAL();
        }

        //Listar Sexo
        public List<SexoEntity> ListarSexo_BL()
        {
            return dal.ListarSexo_DAL();
        }

        //Listar Estado Civil
        public List<EstadoCivilEntity> ListarEstadoCivil_BL()
        {
            return dal.ListarEstadoCivil_DAL();
        }

        //Listar Departamento
        public List<DepartamentoEntity> ListarDepartamento_BL()
        {
            return dal.ListarDepartamento_DAL();
        }

        //Listar Provincia
        public List<ProvinciaEntity> ListarProvincia_BL(string vdepartamento)
        {
            return dal.ListarProvincia_DAL(vdepartamento);
        }

        //Listar Distrito
        public List<DistritoEntity> ListarDistrito_BL(string vdepartamento, string vprovincia)
        {
            return dal.ListarDistrito_DAL(vdepartamento, vprovincia);
        }

        //Listar Tipo Via
        public List<TipoViaEntity> ListarTipoVia_BL()
        {
            return dal.ListarTipoVia();
        }

        //Listar Tipo Poliza
        public List<TipoPolizaEntity> ListarTipoPoliza_BL()
        {
            return dal.ListarTipoPoliza();
        }

        //Registar Poliza
        public List<RespuestaPost> RegistrarPoliza_BL(
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
            return dal.RegistrarPoliza_DAL(
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
        }


    }
}
