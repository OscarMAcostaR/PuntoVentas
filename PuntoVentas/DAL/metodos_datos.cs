﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    internal class metodos_datos
    {
        //método para ejecutar un dataset
        //Utilizado para ejecutar una consulta SQL que devuelve un conjunto de datos
        //que puede contener una o varias tablas con filas y columnas de datos.
        public static DataSet execute_DataSet(string sp, params object[] parametros)
        {
            //instanciamos un DS (DataSet) => Objeto de ADO (Access Data Object)
            DataSet ds = new DataSet();
            //obtenemos la cadena de conexión
            string conn = configuracion.CadenaConexion;
            //creamos una conexión => SqlConnection Objeto de ADO
            SqlConnection SQLcon = new SqlConnection(conn);
            try
            {
                //verificamos si la conexión está abierta
                if (SQLcon.State == ConnectionState.Open)
                {
                    //cerramos la conexión
                    SQLcon.Close();
                }
                else
                {
                    //comando para SQL (sp, conexión) => SqlCommnad objeto de ADO
                    SqlCommand cmd = new SqlCommand(sp, SQLcon);
                    //defino que el comando será ejecutado como una SP (Stored Procedure)
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Psamos el SP
                    cmd.CommandText = sp;

                    //validamos si existen y están completos los parámetros.
                    //si es diferente de null y su residuo es diferente de 0
                    //parametros = { clave : valor }
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parámetros deben estar en pares (clave:valor)");
                    }
                    else
                    {
                        //asignamos los parámetros al comando
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            //SqlParameter => Objeto de ADO
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }

                        //abrimos la conexión
                        SQLcon.Open();
                        //ejecutamos el comando
                        //SqlDataAdapter => Objeto de ADO
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        //llenamos el ds
                        adapter.Fill(ds);
                        //ceeramos la conexión
                        SQLcon.Close();
                    }
                }
                //Retorno el DS (DataSet)
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //verificamos si la conexión está abierta
                if (SQLcon.State == ConnectionState.Open)
                {
                    //cerramos la conexión
                    SQLcon.Close();
                }
            }
        }

        //Métodod que ejecuta un escalar
        //ejecuta una consulta SQL que devuelve un solo valor o una sola columna de dats.
        //retorna el valor de la primera columna y la primera fila del conjutno de resutltado

        public static int execute_Scalar(string sp, params object[] parametros)
        {
            //instanciamos un entero
            int id = 0;
            //obtenemos la cadena de conexión
            string conn = configuracion.CadenaConexion;
            //creamos una conexión => SqlConnection Objeto de ADO
            SqlConnection SQLcon = new SqlConnection(conn);
            try
            {
                //verificamos si la conexión está abierta
                if (SQLcon.State == ConnectionState.Open)
                {
                    //cerramos la conexión
                    SQLcon.Close();
                }
                else
                {
                    //comando para SQL (sp, conexión) => SqlCommnad objeto de ADO
                    SqlCommand cmd = new SqlCommand(sp, SQLcon);
                    //defino que el comando será ejecutado como una SP (Stored Procedure)
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Psamos el SP
                    cmd.CommandText = sp;

                    //validamos si existen y están completos los parámetros.
                    //si es diferente de null y su residuo es diferente de 0
                    //parametros = { clave : valor }
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parámetros deben estar en pares (clave:valor)");
                    }
                    else
                    {
                        //asignamos los parámetros al comando
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            //SqlParameter => Objeto de ADO
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }

                        //abrimos la conexión
                        SQLcon.Open();
                        //ejecutar el comando de forma que reciba un Scalar
                        id = int.Parse(cmd.ExecuteScalar().ToString());
                        //ceeramos la conexión
                        SQLcon.Close();
                    }
                }
                //Retorno el dato
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                //verificamos si la conexión está abierta
                if (SQLcon.State == ConnectionState.Open)
                {
                    //cerramos la conexión
                    SQLcon.Close();
                }
            }
        }

        //Método que ejecuta un NonQuery
        //Utilizado para ejecutar consultas SQL que no devuelven un conjunto de resultados.
        //como sentencias INSERT, UPDATE o DELETE.
        //Retorna un valor entero  que representa el número de filas afectadas por la operación.
        //(por ejemplo, el número de filas insertadas, actualizdas o eliminadas).

        public static int execute_nonQuery(string sp, params object[] parametros)
        {
            //instanciamos un entero
            int id = 0;
            //obtenemos la cadena de conexión
            string conn = configuracion.CadenaConexion;
            //creamos una conexión => SqlConnection Objeto de ADO
            SqlConnection SQLcon = new SqlConnection(conn);
            try
            {
                //verificamos si la conexión está abierta
                if (SQLcon.State == ConnectionState.Open)
                {
                    //cerramos la conexión
                    SQLcon.Close();
                }
                else
                {
                    //comando para SQL (sp, conexión) => SqlCommnad objeto de ADO
                    SqlCommand cmd = new SqlCommand(sp, SQLcon);
                    //defino que el comando será ejecutado como una SP (Stored Procedure)
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Psamos el SP
                    cmd.CommandText = sp;

                    //validamos si existen y están completos los parámetros.
                    //si es diferente de null y su residuo es diferente de 0
                    //parametros = { clave : valor }
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parámetros deben estar en pares (clave:valor)");
                    }
                    else
                    {
                        //asignamos los parámetros al comando
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            //SqlParameter => Objeto de ADO
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }

                        //abrimos la conexión
                        SQLcon.Open();
                        // Ejecuto el Comando sin espear retorno
                        cmd.ExecuteNonQuery();
                        id = 1;
                        //ceeramos la conexión
                        SQLcon.Close();
                    }
                }
                //Retorno el dato
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                //verificamos si la conexión está abierta
                if (SQLcon.State == ConnectionState.Open)
                {
                    //cerramos la conexión
                    SQLcon.Close();
                }
            }
        }
    }
}
