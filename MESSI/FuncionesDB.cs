using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace MESSI
{
    public class FuncionesDB
    {
        public SqlConnection conn;
        private string query;
        DataSet dts;
        
        public void Connectar()
        {
            //Configuration conf = ConfigurationManager.OpenExeConfiguration("Sprint3.exe");

            //ConnectionStringsSection section = conf.GetSection("connectionStrings")

            //as ConnectionStringsSection;

            //if (!section.SectionInformation.IsProtected)
            //{
            //    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            //}

            //conf.Save();

            string cnx = "";
            ConnectionStringSettings conf2 = ConfigurationManager.ConnectionStrings["Sprint3.Properties.Settings.DarkCoreConnectionString"];

            if (conf2 != null)
            {
                cnx = conf2.ConnectionString;
            }
                
            conn = new SqlConnection(cnx);
        }

        public DataSet PortarTaula(string taula)
        {
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;
            query = "SELECT * From " + taula;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, taula);

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string Consulta)
        {
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;
            query = Consulta;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, "Tabla");

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string Consulta, string nomDataTable)
        {
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;
            query = Consulta;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, nomDataTable);

            conn.Close();

            return dts;
        }

        public DataSet Actualitzar()
        {
            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();

            return dts;
        }

        public DataSet Actualitzar(DataSet dts, string consulta)
        {
            int result = 0;

            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(consulta, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();

            return dts;
        }

        public void Executa(string Consulta)
        {
            query = Consulta;

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            int registresAfectats = cmd.ExecuteNonQuery();
            cmd.Dispose();

            conn.Close();
        }
    }
}
