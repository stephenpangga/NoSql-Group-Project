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

        public bool ChangeCustomerInfo(string collectionName, string searchValue, string attribute, string updateValue, string column)
        {
            var result = customer_DAO.UpdateCustomerInfo(collectionName, searchValue, attribute, updateValue, column);
            return result;
        }

        public List<Employees> getAllEmployees(string collectionName) 
        {
            return customer_DAO.getAllEmployees(collectionName);
        }
    }
}
