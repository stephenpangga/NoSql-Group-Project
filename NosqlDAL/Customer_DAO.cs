﻿using System;
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
        

        public bool UpdateCustomerInfo(string collectionName, ObjectId searchValue, string attribute, string updateValue, string column)
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
        public List<User> getAllEmployees()
        {
            var collection = GetAll(UserColl);

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

        public void deleteUser(string id, string searchterm, string collectionName) 
        {
            deleteData(Int32.Parse(id), searchterm, collectionName);
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
