using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingSimple.Model;

namespace UnitTestingSimple.Services
{
    public class InvoiceService
    {
        private static List<Invoice> invoices = new List<Invoice>
        {
            new Invoice
            {
                Id = 1,
                ClientName = "Alan",
                ClientLastName = "Alanov",
                DateOfIssue = DateTime.Now.AddDays(1),
                DateOfCreation = DateTime.Now,
                Amount = 200
            },
            new Invoice
            {
                Id = 2,
                ClientName = "Dylan",
                ClientLastName = "Dylanin",
                DateOfIssue = DateTime.Now.AddDays(2),
                DateOfCreation = DateTime.Now,
                Amount = 500
            },
        };

        public int GenerateNextId()
        {
            if (!invoices.Any())
            {
                return 1;
            }
            return invoices.OrderByDescending(x => x.Id).First().Id + 1;
        }

        public List<Invoice> GetAllInvoices()
        {
            return invoices.ToList();
        }

        public Invoice GetInvoiceById(int id)
        {
            return invoices.FirstOrDefault(i => i.Id == id);
        }
        public Invoice AddInvoice(Invoice model)
        {
            model.Id = GenerateNextId();
            invoices.Add(model);
            return model;
        }
        public Invoice EditInvoice(Invoice model)
        {
            Invoice invoice = invoices.FirstOrDefault(i => i.Id == model.Id);

            invoice.Amount = model.Amount;
            invoice.DateOfCreation = model.DateOfCreation;
            invoice.DateOfIssue = model.DateOfIssue;
            invoice.ClientName = model.ClientName;
            invoice.ClientLastName = model.ClientLastName;

            return invoice;
        }
        public bool DeleteInvoice(int id)
        {
            var invoice = invoices.FirstOrDefault(i => i.Id == id);
            if (invoice == null)
            {
                return false;
            }
            invoices.Remove(invoice);
            return true;
        }

    }
}
