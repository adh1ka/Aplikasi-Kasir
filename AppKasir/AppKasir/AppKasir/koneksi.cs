using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AppKasir
{
    internal class koneksi
    {
        public static OdbcConnection conn = new OdbcConnection("Dsn=dsn_LKS;uid=root;database=project");
        public static OdbcCommand cmd;
        public static OdbcDataReader dr;
        public static OdbcDataAdapter da;
        public static DataTable dt;
        public static DataSet ds;

        public static int getID(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "SELECT ID FROM " + namaTabel + " WHERE ";
            for (int k = 0; k < namaKolom.Length; k++)
            {
                query += " "+namaKolom[k]+" = '" + value[k] + "'";
                if (k < namaKolom.Length - 1)
                {
                    query += " AND ";
                }
            }

            int id;
            conn.Open();
            cmd = new OdbcCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                id = Convert.ToInt32(dr["ID"]);
            }
            else
            {
                id = 0;
            }
            conn.Close();
            return id;
        }

        public static void Tampil(string namaTabel, string[] namaKolom, DataGridView dgv)
        {
            try
            {
                using (OdbcConnection conn = new OdbcConnection("Dsn=dsn_LKS;uid=root;database=project"))
                {
                    conn.Open();
                    string query = "SELECT ";
                    for (int i = 0; i < namaKolom.Length; i++)
                    {
                        query += namaKolom[i];
                        if (i < namaKolom.Length - 1)
                        {
                            query += ",";
                        }
                    }
                    query += " FROM " + namaTabel + "";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgv.DataSource = dt;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static bool validate(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "SELECT * FROM " + namaTabel + " WHERE ";

            for (int i = 0; i < namaKolom.Length; i++)
            {
                query += "" + namaKolom[i] + " = ";
                query += "'" + value[i] + "'";
                if (i < namaKolom.Length - 1)
                {
                    query += " AND ";
                }
            }

            conn.Open();
            cmd = new OdbcCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }
        public static void insert(string namaTabel, string[] namakolom, string[] value)
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO " + namaTabel + "(";

                for (int i = 0; i < namakolom.Length; i++)
                {
                    query += namakolom[i];

                    if (i < namakolom.Length - 1)
                    {
                        query += ",";
                    }
                }
                query += ") VALUES ( ";

                for (int i = 0; i < value.Length; i++)
                {
                    query += "'" + value[i] + "'";

                    if (i < value.Length - 1)
                    {
                        query += ",";
                    }
                }

                query += " ) ";

                cmd = new OdbcCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void update(string namaTabel, string[] namakolom, string[] value, int id)
        {
            try
            {
                conn.Open();

                string query = "UPDATE " + namaTabel + " SET ";

                for (int i = 0; i < namakolom.Length; i++)
                {
                    query += "" + namakolom[i] + " = '" + value[i] + "'";

                    if (i < namakolom.Length - 1)
                    {
                        query += ",";
                    }
                }
                query += "WHERE ID = " + id + "";

                cmd = new OdbcCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void delete(string namaTabel, int id)
        {
            conn.Open();
            cmd = new OdbcCommand("DELETE FROM " + namaTabel + " WHERE ID = " + id + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

