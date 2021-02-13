using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Eims
{
    class Conn
    {
        public MySqlConnection connection;
        private String database;
        private String server;
        private String user;
        private String pwd;

        public Conn() {
            database = "eims_cs2";
            server = "localhost";
            user = "root";
            pwd = "";

            String connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";"
                + "PASSWORD=" + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool openConnection() {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {
                switch (ex.Number) { 
                    case 0:
                        MessageBox.Show("Canneot connect to server. Contact Administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password. Please try again");
                        break;
                }
                return false;
            }
        }

        public bool closeConnection() {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
