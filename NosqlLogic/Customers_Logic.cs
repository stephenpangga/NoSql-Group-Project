using System;
using System.Collections.Generic;
using System.Text;
using NosqlDAL;
using NosqlModel;

namespace NosqlLogic
{
    public class Customers_Logic
    {
        Customer_DAO customer_DAO = new Customer_DAO();
        //make ticket list(to get for one employee) and tickets model
        public List<Ticket> FetchEmployeeTickets(string collectionName, string searchTerm, string attribute)
        {
            return customer_DAO.GetTicketsForCustomer(collectionName, searchTerm, attribute);
        }

        public bool ChangeCustomerInfo(string collectionName, int searchValue, string attribute, string updateValue, string column)
        {
            var result = customer_DAO.UpdateCustomerInfo(collectionName, searchValue, attribute, updateValue, column);
            return result;
        }

        public List<Employees> getAllEmployees(string collectionName) 
        {
            return customer_DAO.getAllEmployees(collectionName);
        }

        public void SendEmail(string email)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            customer_DAO.sendEmail(email, finalString);
            customer_DAO.resetEmail("Users", email, "email", finalString, "password");
        }
    }
}
