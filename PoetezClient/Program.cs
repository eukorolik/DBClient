using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PoetezClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new PoetezClient());
            }
            catch(DataException e)
            {
                HandleException(e, "Data Error");
            }
            catch(MySqlException e)
            {
                HandleException(e, "Database Error");
            }
            catch(PoetezClientException e)
            {
                HandleException(e, "Error");
            }
        }

        private static void HandleException(Exception e, string error)
        {
            MessageBox.Show(e.Message, error, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }

    public class PoetezClientException : Exception
    {
        public PoetezClientException(string message) : base(message) {}
        public PoetezClientException(string message, Exception innerException) : base(message, innerException) {}
    }
}
