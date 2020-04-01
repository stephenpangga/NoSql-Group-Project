using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Driver;
using MongoDB.Bson;
using NosqlModel.Enums;
using System.Net.Mail;



namespace NosqlDAL
{
    public class Customer_DAO : Base
    {
        public List<Ticket> GetTicketsForCustomer(string Coll, string searchTerm, string attribute)
        {
            var documents = GetSpecificDocumentsList(Coll, searchTerm, attribute);

            List<Ticket> tickets = new List<Ticket>();

            foreach(var doc in documents)
            {
                Ticket ticket = new Ticket(doc["Subject"].ToString(), doc["Description"].ToString(), (Status)Enum.Parse(typeof(Status), doc["Status"].ToString()), doc["Deadline"].ToInt32(), (IncidentType)Enum.Parse(typeof(IncidentType), doc["Incidenttype"].ToString()));
                tickets.Add(ticket);
            }

            return tickets;
        }

        public bool UpdateCustomerInfo(string collectionName, int searchValue, string attribute, string updateValue, string column)
        {
            var result = UpdateDocument(collectionName, searchValue, attribute, updateValue, column);
            return result;
            
        }

        public bool resetEmail(string collectionName, string searchValue, string attribute, string updateValue, string column)
        {
            var result = UpdateDocumentbyString(collectionName, searchValue, attribute, updateValue, column);
            return result;

        }

        //Get all the employes from the 'user' table
        public List<Employees> getAllEmployees(string collectionName)
        {
            var collection = GetAllEmployees(collectionName);

            List<Employees> employees = new List<Employees>();

            //Use the Employees model and fill all the needed data into it, forming a list which can be used in the logic layer and the form itself.
            foreach (var doc in collection) 
            {
                Employees employee = new Employees(doc["userId"].ToInt32(), doc["email"].ToString(), doc["password"].ToString(), 
                    doc["firstName"].ToString(), doc["lastName"].ToString(), (Roles)Enum.Parse(typeof(Roles), doc["role"].ToString()));

                employees.Add(employee);
            }

            return employees;
        }

        public void enterUser(int id, string mail, string password, string firstname, string lastname, string role) 
        {
            InsertUser(id, mail, password, firstname, lastname, role);
        }

        public void  sendEmail(string email, string tempPass)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("jumbomumbo399@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Password reset request.";
                mail.Body = "Here is a temporary password for you to login: "+ tempPass+ ".Make sure to change your password when you log in.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("jumbomumbo399@gmail.com", "Haarlem123!");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
