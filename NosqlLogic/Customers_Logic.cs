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
        public List<Ticket> FetchEmployeeTickets(string searchTerm)
        {
            return customer_DAO.GetTicketsForCustomer("Tickets", searchTerm, "Reportedby");
        }

        public bool ChangeCustomerInfo(int searchValue, string updateValue, string column)
        {
            var result = customer_DAO.UpdateCustomerInfo("Users", searchValue, "userId", updateValue, column);
            return result;
        }


        //Method made by Tim
        public List<User> getAllEmployees(string collectionName) 
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

        //Tim - Send the new user info to the database
        public void createUser(string firstname, string lastname, string email, string role) 
        {
            //create the id
            int id = getNewID();
            string password = getNewPassword();
            customer_DAO.enterUser(id, email, password, firstname, lastname, role);

        }

        //Tim- create a new user ID which is 1 more than the last one.
        public int getNewID() 
        {
            int id = 0;
            List<User> employees = customer_DAO.getAllEmployees("Users");
            foreach (User employee in employees) 
            { if (employee.userId > id) { id = employee.userId; } }
            return id + 1;
        }

        public string getNewPassword() 
        {
            string password = "";
            string passstring = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            for(int i = 0; i < 6; i++)
            {
                int number = rnd.Next(0, 62);
                string sub = passstring.Substring(number, 1);
                password = password + sub;
            }
            return password;
        }
    }
}
