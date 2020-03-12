using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NosqlModel
{
    public class User

    {
        public string name { get; set; }
        public string email { get; set; }
    }
}
