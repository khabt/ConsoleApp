using ConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static string pattern = System.Configuration.ConfigurationManager.AppSettings["pattern"];
        public static string serial = System.Configuration.ConfigurationManager.AppSettings["serial"];
        public static string comid = System.Configuration.ConfigurationManager.AppSettings["comid"];
        public static string id = System.Configuration.ConfigurationManager.AppSettings["id"];
        public static string NoList = System.Configuration.ConfigurationManager.AppSettings["noList"];
        public static string fromNo = System.Configuration.ConfigurationManager.AppSettings["fromNo"];

        static void Main(string[] args)
        {
            //Update(int.Parse(id), int.Parse(comid));
            //Update(pattern, serial, int.Parse(comid), NoList);
            Update(pattern, serial, int.Parse(comid), int.Parse(fromNo));
            Console.ReadKey();
        }

        static void Update(int id, int comid)
        {
            VatInvoiceServices vat = new VatInvoiceServices();
            vat.UpdateInv(id, comid);
        }
        static void Update(string pattern, string serial, int comid, string NoList)
        {
            VatInvoiceServices vat = new VatInvoiceServices();
            vat.UpdateInv(pattern, serial, comid, Helper.ChangeArray(NoList));
        }

        static void Update(string pattern, string serial, int comid, int fromNo)
        {
            VatInvoiceServices vaaa = new VatInvoiceServices();
            vaaa.UpdateInv(pattern, serial, comid, fromNo);
        }
    }
}
