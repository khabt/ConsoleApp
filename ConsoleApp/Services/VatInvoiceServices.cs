using ConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class VatInvoiceServices
    {
        EFDataContext db = null;
        public VatInvoiceServices()
        {
            db = new EFDataContext();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        public void UpdateInv(string pattern, string serial, int comid)
        {
            Console.WriteLine($"pattern: {pattern} - serial: {serial} - comid {comid}");
            List<VATInvoice> list = GetListInv(pattern, serial, comid);
            foreach (VATInvoice invoice in list)
            {
                invoice.AmountInWords = new NumberToLeter().DocTienBangChu((long)invoice.Amount, invoice.CurrencyUnit == "" ? "VND" : invoice.CurrencyUnit);
                Console.WriteLine($"Amount: {invoice.Amount} - AmountWord: {invoice.AmountInWords}");
                db.VATInvoices.Add(invoice);
                db.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void UpdateInv(string pattern, string serial, int comid, int[] NoList)
        {
            Console.WriteLine($"pattern: {pattern} - serial: {serial} - comid {comid} - NoList: ");
            foreach (var item in NoList)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
            List<VATInvoice> list = GetListInv(pattern, serial, comid, NoList);
            Console.WriteLine($"Count: {list.Count}");
            Console.WriteLine("----------------------------------------");            
            foreach (VATInvoice invoice in list)
            {
                Console.WriteLine($"id: {invoice.id}");
                invoice.AmountInWords = new NumberToLeter().DocTienBangChu((long)invoice.Amount, invoice.CurrencyUnit == "" ? "VND" : invoice.CurrencyUnit);
                Console.WriteLine($"Amount: {invoice.Amount} - AmountWord: {invoice.AmountInWords}");
                db.VATInvoices.Add(invoice);
                db.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void UpdateInv(string pattern, string serial, int comid, int fromNo)
        {
            Console.WriteLine($"pattern: {pattern} - serial: {serial} - comid {comid} - fromNo: {fromNo}");
            Console.WriteLine();
            List<VATInvoice> list = GetListInv(pattern, serial, comid, fromNo);
            Console.WriteLine($"Count: {list.Count}");
            Console.WriteLine("----------------------------------------");            
            foreach (VATInvoice invoice in list)
            {
                Console.WriteLine($"id: {invoice.id}");
                invoice.AmountInWords = new NumberToLeter().DocTienBangChu((long)invoice.Amount, invoice.CurrencyUnit == "" ? "VND" : invoice.CurrencyUnit);
                Console.WriteLine($"Amount: {invoice.Amount} - AmountWord: {invoice.AmountInWords}");
                db.VATInvoices.Add(invoice);
                db.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void UpdateInv(int id, int comid)
        {
            Console.WriteLine($"id: {id} - comid: {comid}");
            Console.WriteLine("----------------------------------------");
            VATInvoice invoice = GetInv(id, comid);
            if(invoice != null)
            {                
                invoice.AmountInWords = new NumberToLeter().DocTienBangChu((long)invoice.Amount, invoice.CurrencyUnit == "" ? "VND" : invoice.CurrencyUnit);
                Console.WriteLine($"Amount: {invoice.Amount} - AmountWord: {invoice.AmountInWords}");
                db.VATInvoices.Add(invoice);
                db.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<VATInvoice> GetListInv(string pattern, string serial, int comid)
        {
            IQueryable<VATInvoice> invoice = db.VATInvoices.Where(inv => inv.Pattern.Contains(pattern) && inv.Pattern.Contains(pattern) && inv.ComID == comid);
            return invoice.ToList();
        }

        public VATInvoice GetInv(int id, int comid)
        {
            VATInvoice invoice = db.VATInvoices.Where(inv => inv.ComID == comid && inv.id == id).FirstOrDefault();
            return invoice;
        }

        public List<VATInvoice> GetListInv(string pattern, string serial, int comid, int[] NoList)
        {
            List<VATInvoice> invoice = db.VATInvoices.Where(inv => inv.Pattern.Contains(pattern) && inv.Serial.Contains(serial) && inv.ComID == comid && NoList.Contains((int)inv.No)).ToList();
            return invoice;
        }

        public List<VATInvoice> GetListInv(string pattern, string serial, int comid, int fromNo)
        {
            List<VATInvoice> invoice = db.VATInvoices.Where(inv => inv.Pattern.Contains(pattern) && inv.Serial.Contains(serial) && inv.ComID == comid && inv.No <= fromNo && inv.No >= 1).ToList();
            return invoice;
        }
    }
}
