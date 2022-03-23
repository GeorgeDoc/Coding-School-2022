using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    internal class MockData {

        //Products
        Product Freddo = new Product() {
            Code = "001",
            Price = 1.90,
            Description = "Cold coffee",
            Cost = 0.50
        };
        Product Tea = new Product() {
            Code = "002",
            Price = 1.50,
            Description = "Hot aromatic beverage",
            Cost = 0.40
        };
        Product Burger = new Product() {
            Code = "003",
            Price = 5.50,
            Description = "Hot aromatic beverage",
            Cost = 3.00
        };

        //Product Categories
        ProductCategory Coffees = new ProductCategory() {
            Code = "1",
            Description = "Coffees",
        };
        ProductCategory Beverages = new ProductCategory() {
            Code = "2",
            Description = "Beverages",
        };
        ProductCategory Food = new ProductCategory() {
            Code = "3",
            Description = "Food",
        };

        //Employees
        Employee emp1 = new Employee() {
            Name = "George",
            Surname = "Aivaliotis",
            SalaryPerMonth = 5000,
        };
        Employee emp2 = new Employee() {
            Name = "George",
            Surname = "Aivaliotis",
            SalaryPerMonth = 5000,
        };

        //Customers
        Customer cust1 = new Customer() {
            Code = "C001"
        };
        Customer cust2 = new Customer() {
            Code = "C002"
        };

        //TransactionLines
        TransactionLine line1 = new TransactionLine() {
            Price = 3,
            TotalPrice = 6,
            Discount = false,
        };        
        TransactionLine line2 = new TransactionLine() {
            Price = 5,
            TotalPrice = 10,
            Discount = true,
        };

        //Transactions
        Transaction transaction = new Transaction() {
            TotalPrice = 10,
            TransCost = 4,
            TransLines = new List<TransactionLine>()
        };
    }
}
