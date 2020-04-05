using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Driver;
using MongoDB.Bson;
using NosqlModel.Enums;
using System.Net.Mail;
using System.Net;



namespace NosqlDAL
{
    public class Customer_DAO : Base
    {
        

        public bool UpdateCustomerInfo( ObjectId searchValue, string attribute, string updateValue, string column)
        {
            var result = UpdateDocument(UserColl, searchValue, attribute, updateValue, column);
            return result;
            
        }

        public bool resetPass( string searchValue, string updateValue)
        {
            var result = UpdateDocumentbyString(UserColl, searchValue, "email", updateValue, "password");
            return result;

        }

        //Get all the employes from the 'user' table
        public List<User> getAllEmployees(string collectionName)
        {
            var collection = GetAll(collectionName);

            List<User> employees = new List<User>();

            //Use the Employees model and fill all the needed data into it, forming a list which can be used in the logic layer and the form itself.
            foreach (var doc in collection) 
            {
                User employee = new User(doc["userId"].ToInt32(), doc["email"].ToString(), doc["password"].ToString(),
                    doc["firstName"].ToString(), doc["lastName"].ToString(), (Roles)Enum.Parse(typeof(Roles), doc["role"].ToString()))
                {
                    id = (ObjectId)doc.GetValue("_id")
                };

                employees.Add(employee);
            }

            return employees;
        }

        //Tim- update empoyee
        public void updateUser(int id, string value, string column) 
        {
            UpdateUser(id, value, column);
        }

        public void deleteUser(int id, string searchterm, string collectionName) 
        {
            deleteData(id, searchterm, collectionName);
        }

        public void enterUser(int id, string mail, string password, string firstname, string lastname, string role) 
        {
            InsertUser(id, mail, password, firstname, lastname, role);
        }

        public void  sendEmail(string email, string tempPass)
        {
            var fromAddress = new MailAddress("jumbomumbo399@gmail.com", "Admin");
            var toAddress = new MailAddress(email);
            const string fromPassword = "Haarlem123!";
            const string subject = "Password reset request.";
            string body = "Here is a temporary password for you to login: " + tempPass + ".Make sure to change your password when you log in.Ignore this email if you did not request a reset of password or if you do not know the reason of this email.";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
