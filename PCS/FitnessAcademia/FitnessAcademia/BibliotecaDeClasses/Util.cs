using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClasses
{
    public static class Util
    {
        public static string GetStringRead(SqlDataReader reader, string columnName)
        {
            int ord = -1;
            string retorno = "";
            try
            {
                ord = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(ord))
                    return null;
                retorno = reader.GetString(ord);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new Exception("Campo não encontrado: " + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro no campo " + columnName + ": " + e.Message);
            }
            return retorno;
        }

        public static int GetIntRead(SqlDataReader reader, string columnName)
        {
            int ord = -1;
            int retorno = 0;
            try
            {
                ord = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(ord))
                    return 0;
                retorno = reader.GetInt32(ord);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new Exception("Campo não encontrado: " + e.Message);
            }
            catch (Exception)
            {
                return 0;
            }
            return retorno;
        }

        public static Double GetDoubleRead(SqlDataReader reader, string columnName)
        {
            int ord = -1;
            Double retorno = 0;
            try
            {
                ord = reader.GetOrdinal(columnName);
                if (reader.IsDBNull(ord))
                    return 0;
                retorno = Convert.ToDouble(reader.GetDecimal(ord));
            }
            catch (IndexOutOfRangeException e)
            {
                throw new Exception("Campo não encontrado: " + e.Message);
            }
            catch (Exception)
            {
                return 0;
            }
            return retorno;
        }

        public static bool validarCpf(string cpf)
        {
            int k = 0;
            int digito = 0;
            int soma = 0;
            string sNum = "";
            string sDig = "";

            try
            {
                sNum = cpf.Substring(0, cpf.Length - 2);
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
            for (int i = 1; i <= 2; i++)
            {
                k = 2;
                soma = 0;
                for (int j = sNum.Length; j > 0; j--)
                {
                    try
                    {
                        soma += Convert.ToInt32(sNum.Substring(j-1 , 1)) * k;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        return false;
                    }
                    k++;
                }
                digito = 11 - soma % 11;
                if (digito >= 10)
                    digito = 0;
                sNum += digito.ToString();
                sDig += digito.ToString();
            }
            return sNum.CompareTo(cpf) == 0 ? true : false;
        }
    }
}
