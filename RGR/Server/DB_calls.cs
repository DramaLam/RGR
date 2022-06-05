using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RGR.Server
{
    public class DB_calls
    {

        private static string connectionString = @"Data Source=(local);Initial Catalog = RGR; Integrated Security = True";

        private static DB_connect dB = new DB_connect(connectionString);

        public static SqlDataReader showAutoManager()
        {
            dB.sqlCommandString = "select * from Auto_Manager ";
            return dB.readTable();
        }

        public static SqlDataReader application_Manager()
        {
            dB.sqlCommandString = "select * from Application_Manager ";
            return dB.readTable();
        }

        public static SqlDataReader showClientManager()
        {
            dB.sqlCommandString = "select * from Client_Manager ";
            return dB.readTable();
        }

        public static SqlDataReader showReturnManager()
        {
            dB.sqlCommandString = "select * from Return_Manager ";
            return dB.readTable();
        }

        public static SqlDataReader damagedAuto()
        {
            dB.sqlCommandString = "select * from DamagedAuto ";
            return dB.readTable();
        }

        public static SqlDataReader showProfitManager()
        {
            dB.sqlCommandString = "select * from Profit_Manager ";
            return dB.readTable();
        }
        
        public static SqlDataReader showClientsOfYear()
        {
            dB.sqlCommandString = "select * from ClientsOfYear ";
            return dB.readTable();
        }

        // Client
        public static SqlDataReader showAutoClient()
        {
            dB.sqlCommandString = "select * from Auto_Client ";
            return dB.readTable();
        }
        

        public static SqlDataReader searchClient(string tel, string password)
        {
            dB.sqlCommandString = "exec ClientSearch " + "'" + tel + "'," + "'" + password + "'";
            return dB.readTable();
        }

        public static string newClient(string fio, string dataB, string passSer, string passID, string address, string tel, string password)
        {
            DateTime dateTimeNow = DateTime.Now;
            dB.sqlCommandString = "exec Client " + "'" + fio + "'," + "'" + dataB + "'," + "'" + passSer + "'," + "'" + passID + "'," + "'" + address + "'," + "'" + tel + "'," + "'" + dateTimeNow + "'," + "'" + password + "'";
            return "Добавлено данных:  " + dB.DB_Changes();
        }
        
        public static string newAuto(string reg, string model, string marka, string color, string state, string power, string price)
        {
            //DateTime dateTimeNow = DateTime.Now;
            dB.sqlCommandString = "exec Automobile " + "'" + reg + "'," + "'" + model + "'," + "'" + marka + "'," + "'" + color + "'," + "'" + state + "'," + "'" + power + "'," + "'" + price + "'";
            return "Добавлено данных:  " + dB.DB_Changes();
        }

        public static SqlDataReader сlientCheque(string tel)
        {
            dB.sqlCommandString = "exec ClientCheque " + "'" + tel + "'";
            return dB.readTable();
        }

        public static SqlDataReader clientApplication(string tel)
        {
            dB.sqlCommandString = "exec ClientApplication " + "'" + tel + "'";
            return dB.readTable();
        }

        public static SqlDataReader clientInfo(string tel)
        {
            dB.sqlCommandString = "exec ClientInfo " + "'" + tel + "'";
            return dB.readTable();
        }

        public static SqlDataReader availableCars(string dataS, string dataE)
        {
            dB.sqlCommandString = "exec AvailableCars " + "'" + dataS + "'," + "'" + dataE + "'"; 
            return dB.readTable();
        }

        public static SqlDataReader availableCarsPrice(string dataS, string dataE, string priceMin, string priceMax)
        {
            dB.sqlCommandString = "exec AvailableCarsPrice " + "'" + dataS + "'," + "'" + dataE + "'," + priceMin + "," + priceMax; 
            return dB.readTable();
        }

        public static string applicationAdd(string model, string dataS, string dataE, string tel)
        {
            dB.sqlCommandString = "exec ApplicationAdd " + "'" + model + "'," + "'" + dataS + "'," + "'" + dataE + "'," + "'" + tel + "'," + "'На рассмотрение'";
            return "Заявка на рассмотрение: " + dB.DB_Changes();
        }

        public static string appUpdate(string reg, string status)
        {
            dB.sqlCommandString = "exec AppUpdate " + reg + "," + "'" + status + "'";
            return "Данных обновлено " + dB.DB_Changes();
        }

        public static string autoUpdatePrice(string reg, string price)
        {
            dB.sqlCommandString = "exec AutoUpdatePrice " + "'" + reg + "'," + "'" + price + "'";
            return "Данных обновлено " + dB.DB_Changes();
        }

        public static string autoUpdateStatus(string reg, string status)
        {
            dB.sqlCommandString = "exec AutoUpdateStatus " + "'" + reg + "'," + "'" + status + "'";
            return "Данных обновлено " + dB.DB_Changes();
        }

        public static string autoDelete(string reg)
        {
            dB.sqlCommandString = "exec AutoDelete " + "'" + reg + "'";
            return "Данных обновлено " + dB.DB_Changes();
        }


        //public static void returnAdd()
        //{
        //    dB.sqlCommandString = "exec ReturnAdd";
        //}

        //public static void chequeAdd()
        //{
        //    dB.sqlCommandString = "exec ChequeAdd";
        //}

        public static string returnAdd()
        {
            dB.sqlCommandString = "exec ReturnAdd";
            return "Данных обновлено " + dB.DB_Changes();
        }

        public static string chequeAdd()
        {
            dB.sqlCommandString = "exec ChequeAdd";
            return "Данных обновлено " + dB.DB_Changes();
        }

        public static string chequeUpdate(string reg)
        {
            dB.sqlCommandString = "exec ChequeUpdate" + "'" + reg + "'";
            return "Изменено данных по счету: " + dB.DB_Changes();
        }

        public static string dateReturnUpdate(string reg, string date)
        {
            dB.sqlCommandString = "exec DateReturnUpdate" + "'" + reg + "'," + "'" + date + "'";
            return "Изменено данных по возврату: " + dB.DB_Changes();
        }

        public static string returnUpdateStatus(string reg, string status)
        {
            dB.sqlCommandString = "exec ReturnUpdateStatus" + "'" + reg + "'," + "'" + status + "'";
            return "Изменено данных по возврату: " + dB.DB_Changes();
        }

        public static string dateChequeUpdate(string reg, string sum)
        {
            dB.sqlCommandString = "exec DateChequeUpdate" + "'" + reg + "'," + "'" + sum + "'";
            return "Изменено данных по счету: " + dB.DB_Changes();
        }

        public static SqlDataReader IncomePerYear(string year)
        {
            dB.sqlCommandString = "exec IncomePerYear " +  year;
            return dB.readTable();
        }

        public static SqlDataReader diagram()
        {
            dB.sqlCommandString = "select * from Diagram";
            return dB.readTable();
        }
    }
}
