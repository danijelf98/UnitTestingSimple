using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingSimple.Model;
using UnitTestingSimple.Services;

namespace UnitTestingSimple.UnitTest
{
    public class InvoiceServiceUnitTest
    {
        private readonly InvoiceService invoiceService;

        public InvoiceServiceUnitTest()
        {
            invoiceService = new InvoiceService();
        }

        [Fact]
        public void GetInvoiceById_GetsInvoiceById_ReturnsAnInvoiceByInsertedId()
        {
            var response = invoiceService.GetInvoiceById(2);
            Assert.Equal(2, response.Id);
            Assert.NotNull(response);
        }
        [Fact]
        public void AddInvoice_AddsAnInvoiceToList_ReturnsAnAddedInvoice()
        {
            Invoice invoice = new Invoice
            {
                Amount = 100,
                DateOfIssue = DateTime.Now.AddDays(25),
                DateOfCreation = DateTime.Now,
                ClientName = "Test Name",
                ClientLastName = "Test Last Name"
            };
            var response = invoiceService.AddInvoice(invoice);
            Assert.NotNull(response);
            Assert.Equal(3, response.Id);
        }
        [Fact]
        public void DeleteInvoice_GetsAllInvoicesAndDeletesFirstInvoice_ChecksNumberOfOtherElements()
        {
            var invoices = invoiceService.GetAllInvoices();
            Assert.NotEmpty(invoices);
            Assert.Equal(2, invoices.Count());
            invoiceService.DeleteInvoice(invoices[0].Id);

            invoices = invoiceService.GetAllInvoices();
            Assert.NotEmpty(invoices);
            Assert.Single(invoices);
        }
        [Fact]
        public void GenerateNextId_GeneratesNextId_ReturnsANextId()
        {
            var response = invoiceService.GenerateNextId();
            Assert.NotNull(response);
            Assert.Equal(4, response);
        }

        [Fact]
        public void GetAllInvoices_GetsAllInvocies_ReturnsAListOfInvoices()
        {
            var response = invoiceService.GetAllInvoices();
            Assert.NotEmpty(response);
            Assert.Equal(2, response.Count());
        }
        [Fact]
        public void EditInvoice()
        {
            var invoices = invoiceService.GetAllInvoices();
            Assert.NotEmpty(invoices);

            var result = invoices[0];
            string nameTest = "test name";
            string lastNameTest = "test last name";

            result.ClientName = nameTest;
            result.ClientLastName = lastNameTest;

            result = invoiceService.EditInvoice(result);

            Assert.Equal(nameTest, result.ClientName);
            Assert.Equal(lastNameTest, result.ClientLastName);
        }


    }
}
