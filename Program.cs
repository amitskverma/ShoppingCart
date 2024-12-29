using System;   
using System.Collections.Generic;
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;   


class Program
{
	static void Main(string[] args)
	{
    Customer customer = new Customer();
    
    customer.customerId = 1001;
    customer.customerName = "Alfred";
    customer.address = "12th Block, Gandhi Square";
    customer.phoneNumber = 9876545678;
    customer.emailId = "alfred@gmail.com";
    int customerId = customer.customerId;
    string customerName = customer.customerName;
    string address = customer.address;
    long phoneNumber = customer.phoneNumber;
    string emailId = customer.emailId;

    Console.WriteLine("Customer ID = {0}", customerId);
    Console.WriteLine("Customer Name = {0}", customerName);
    Console.WriteLine("Address = {0}", address);
    Console.WriteLine("Phone Number = {0}", phoneNumber);
    Console.WriteLine("Email ID = {0}", emailId);
}
}