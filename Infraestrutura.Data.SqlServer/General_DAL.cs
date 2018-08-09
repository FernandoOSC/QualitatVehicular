using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Infraestrutura.Data.SqlServer
{
    public class General_DAL
    {
        Conexion_DAL cn = new Conexion_DAL();

//***************************************************************************************************************************************
//REGISTRO POLIZA *******************************************************************************************************************
//***************************************************************************************************************************************


        //Listado Tipo Vehiculo
        public List<TipoVehiculoEntity> ListarTipoVehiculo_DAL()
        {
            List<TipoVehiculoEntity> listado = new List<TipoVehiculoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoVehiculo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoVehiculoEntity clase = new TipoVehiculoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();         

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Uso
        public List<TipoUsoEntity> ListarTipoUso_DAL()
        {
            List<TipoUsoEntity> listado = new List<TipoUsoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoUso", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoUsoEntity clase = new TipoUsoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Marca Automovil
        public List<MarcaVehiculoEntity> ListarMarcaVehiculo_DAL()
        {
            List<MarcaVehiculoEntity> listado = new List<MarcaVehiculoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListaMarcaVehiculo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                MarcaVehiculoEntity clase = new MarcaVehiculoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Modelo Vehiculo
        public List<ModeloVehiculoEntity> ListarModeloVehiculo_DAL(int id_marca)
        {
            List<ModeloVehiculoEntity> listado = new List<ModeloVehiculoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarModelo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_marca", id_marca);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ModeloVehiculoEntity clase = new ModeloVehiculoEntity();
                clase.smidmodelo = int.Parse(dr["smidmodelo"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Documento
        public List<TipoDocumentoEntity> ListarTipoDocumento_DAL()
        {
            List<TipoDocumentoEntity> listado = new List<TipoDocumentoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoDocumento", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;            

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoDocumentoEntity clase = new TipoDocumentoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Tipo Documento
        public List<NacionalidadEntity> ListarNacionalidad_DAL()
        {
            List<NacionalidadEntity> listado = new List<NacionalidadEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarNacionalidad", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NacionalidadEntity clase = new NacionalidadEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Sexo
        public List<SexoEntity> ListarSexo_DAL()
        {
            List<SexoEntity> listado = new List<SexoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_Sexo", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                SexoEntity clase = new SexoEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Listado Estado Civil
        public List<EstadoCivilEntity> ListarEstadoCivil_DAL()
        {
            List<EstadoCivilEntity> listado = new List<EstadoCivilEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_EstadoCivil", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EstadoCivilEntity clase = new EstadoCivilEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Departamento
        public List<DepartamentoEntity> ListarDepartamento_DAL()
        {
            List<DepartamentoEntity> listado = new List<DepartamentoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarDepartamento", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DepartamentoEntity clase = new DepartamentoEntity();
                clase.vdepartamento= dr["vdepartamento"].ToString();
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Provincia
        public List<ProvinciaEntity> ListarProvincia_DAL(string vdepartamento)
        {
            List<ProvinciaEntity> listado = new List<ProvinciaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarProvincia", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idDepartamento", vdepartamento);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProvinciaEntity clase = new ProvinciaEntity();
                clase.vprovincia = dr["vprovincia"].ToString();
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Distrito
        public List<DistritoEntity> ListarDistrito_DAL(string vdepartamento, string vprovincia)
        {
            List<DistritoEntity> listado = new List<DistritoEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_ListarDistrito", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idDepartamento", vdepartamento);
            cmd.Parameters.AddWithValue("@idProvincia", vprovincia);

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DistritoEntity clase = new DistritoEntity();
                clase.vdistrito = dr["vprovincia"].ToString();
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Tipo Via
        public List<TipoViaEntity> ListarTipoVia()
        {
            List<TipoViaEntity> listado = new List<TipoViaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoVia", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoViaEntity clase = new TipoViaEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Tipo Poliza
        public List<TipoPolizaEntity> ListarTipoPoliza()
        {
            List<TipoPolizaEntity> listado = new List<TipoPolizaEntity>();

            SqlCommand cmd = new SqlCommand("SP_VEH_TipoPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoPolizaEntity clase = new TipoPolizaEntity();
                clase.smiddetalle = int.Parse(dr["smiddetalle"].ToString());
                clase.vdescripcion = dr["vdescripcion"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }

        //Registar Poliza
        public List<RespuestaPost> RegistrarPoliza_DAL(
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
            List<RespuestaPost> listado = new List<RespuestaPost>();

            SqlCommand cmd = new SqlCommand("SP_VEH_RegistrarPoliza", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@smidtablatipopoliza", smidtablatipopoliza);
            cmd.Parameters.AddWithValue("@vplaca", vplaca);
            cmd.Parameters.AddWithValue("@smidmodelo", smidmodelo);
            cmd.Parameters.AddWithValue("@smaniofabrica", smaniofabrica);
            cmd.Parameters.AddWithValue("@vmotor", vmotor);
            cmd.Parameters.AddWithValue("@svin", svin);
            cmd.Parameters.AddWithValue("@smnroasiento", smnroasiento);
            cmd.Parameters.AddWithValue("@vcolor", vcolor);
            cmd.Parameters.AddWithValue("@desumaasegurada", desumaasegurada);
            cmd.Parameters.AddWithValue("@smidtablaclasevehiculo", smidtablaclasevehiculo);

            cmd.Parameters.AddWithValue("@idnrodocumento", idnrodocumento);
            cmd.Parameters.AddWithValue("@vnombres", vnombres);
            cmd.Parameters.AddWithValue("@vcelular", vcelular);
            cmd.Parameters.AddWithValue("@vtelefono1", vtelefono1);
            cmd.Parameters.AddWithValue("@vemail", vemail);
            cmd.Parameters.AddWithValue("@vreferencia", vreferencia);
            cmd.Parameters.AddWithValue("@vnumero", vnumero);
            cmd.Parameters.AddWithValue("@vnombrevia", vnombrevia);
            cmd.Parameters.AddWithValue("@smIdTipoVia", smIdTipoVia);
            cmd.Parameters.AddWithValue("@smestadocivil", smestadocivil);
            cmd.Parameters.AddWithValue("@vdepartamento", vdepartamento);
            cmd.Parameters.AddWithValue("@vprovincia", vprovincia);
            cmd.Parameters.AddWithValue("@vdistrito", vdistrito);
            cmd.Parameters.AddWithValue("@dfechanac", dfechanac);
            cmd.Parameters.AddWithValue("@btsexo", btsexo);
            cmd.Parameters.AddWithValue("@vapellidopat", vapellidopat);
            cmd.Parameters.AddWithValue("@vapellidomat", vapellidomat);


            cn.getcn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RespuestaPost clase = new RespuestaPost();
                clase.respuesta = dr["respuesta"].ToString();

                listado.Add(clase);
            }

            dr.Close();
            cmd.Dispose();
            cn.getcn.Close();

            return listado;
        }





    }
}
