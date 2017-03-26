using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Univer_Project_Worker_Side
{
    class Processor
    {
        public static string CLogin = "";
        public static string CPassword = "";
        public  const string SITE_NAME = @"http://localhost:8080/";
        private  const string GET_PARAM_QUERY = "getparam/";
        private  const string REGNEW_QUERY = "regnew/";
        private  const string CHSTATE_QUERY = "chstate/";
        private const string GETREPORT_QUERY = "genrep/";
        private const string GET_GENERAL_REPORT_QUERY = "getgenrep/";
        private const string NEW_USER_QUERY = "nuser/";
        private const string ENTER_SYSTEM_QUERY = "ensys/";
        private const string REPORT_DEFAULT_PATH = "Data\\Reports\\report.xlsx";
        private const string REPORTS_FOLDER = "Data\\Reports";
        private const string LOG_PATH = "Data\\Logs\\log.txt";

        public static string getState(string fnum, string snum, string tnum, string param)
        {
            string fullSite = SITE_NAME + GET_PARAM_QUERY + fnum + "/" + snum + "/" + tnum + "/" + "0" + param + "/";
            string outputs = "";
            WebRequest request = WebRequest.Create(fullSite);
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException exw)
            {
                Log(exw, "GetState");
                return "Отсутствует связь с сервером";
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string line;
                while ((line = reader.ReadLine()) != null) outputs += line;
                return outputs;
            }
        }

        public static string regNew(string fnum, string snum, string tnum)
        {
            string outputs = "";
            string fullSite = SITE_NAME + REGNEW_QUERY + fnum + "/" + snum + "/" + tnum + "/" + CLogin + "/" + CPassword;
            WebRequest request = WebRequest.Create(fullSite);
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException exw)
            {
                Log(exw, "RegNew");
                return "Отсутствует связь с сервером";
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    outputs += line;
                }
            }
            return outputs;
        }

        public static string chState(string fnum, string snum, string tnum, string stnum)
        {
            string outputs = "";
            string fullSite = SITE_NAME + CHSTATE_QUERY + fnum + "/" + snum + "/" + tnum + "/" + stnum + "/" + CLogin + "/" + CPassword;
            WebRequest request = WebRequest.Create(fullSite);
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException exw)
            {
                Log(exw, "chState");
                return "Отсутствует связь с сервером";
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    outputs += line;
                }
            }
            return outputs;
        }

        public static string newUser(string login, string password)
        {
            string fullSite = SITE_NAME + NEW_USER_QUERY + login + "/" + password + "/" + CLogin + "/" + CPassword;
            string outputs = "";
            WebRequest request = WebRequest.Create(fullSite);
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException exw)
            {
                Log(exw, "New User");
                return "Отсутствует связь с сервером";
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    outputs += line;
                }
            }
            return outputs;
        }

        public static void GetReport(string paramNo, string from, string to)
        {
            string fullSite = SITE_NAME + GETREPORT_QUERY + paramNo + "/" + from + "/" + to + "/" + CLogin + "/" + CPassword;
            new WebClient().DownloadFile(fullSite, "Data/Reports/report.xlsx");
        }

        public static void Log(Exception ex, string from)
        {
            using (StreamWriter writer = File.AppendText(LOG_PATH))
            {
                writer.WriteLine("\t\t\tOccured On "+DateTime.Now.ToString()+" in" + from);
                writer.WriteLine("Message : " + ex.Message);
                writer.WriteLine("Source : "+ ex.Source);
                writer.WriteLine("StackTrace : " + ex.StackTrace);
            }
        }

        public static void GetGeneralReport()
        {
            string fullSite = SITE_NAME + GET_GENERAL_REPORT_QUERY + CLogin + "/" + CPassword;
            new WebClient().DownloadFile(fullSite, "Data/Reports/general.xlsx");
        }

        public static string Enter(string login, string password)
        {
            string outputs = "";
            string fullSite = SITE_NAME + ENTER_SYSTEM_QUERY + login + "/" + password;
            WebRequest request = WebRequest.Create(fullSite);
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException exw)
            {
                Log(exw, "In entering system");
                return "Нет связи с сервером";
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string line = "";
                while((line = reader.ReadLine())!=null)
                {
                    outputs += line;
                }
            }
            return outputs;
        }
    }
}
