using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Roles
    {
        public int C_IdRolEmpleado { get; set; }
        public string C_StrDescripcion { get; set; }
        public string C_StrUsuarioModifica { get; set; }


        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();
        public DataTable ConsultaRol()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLROLES";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Consulta_Rol(int IdRol)
        {
            string sentencia = "";
            try
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE IdRolEmpleado = {IdRol}";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Filtrar_Rol(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE StrDescripcion like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarRol()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLROLES";
                DataTable dt = new DataTable();
                dt = AccesoDatos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public string ActualizarRol()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_parametros("@StrDescripcion", C_StrDescripcion));


                mensaje = AccesoDatos.Ejecutar_Procedimiento("actualizar_Roles", lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ACTUALIZACIÓN DEL ROL" + ex.Message;
            }
            return mensaje;
        }

    }
}
