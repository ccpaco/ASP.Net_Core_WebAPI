using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

//entity model as class Book
namespace BooksApi.Models
{
    public class Book
    {
        [BsonId] // labels this as primary key
        [BsonRepresentation(BsonType.ObjectId)] // mongo accepts string parameters and converts to object for us
        public string Id { get; set; }

        [BsonElement("Name")] // represents property name in MongoDB collection
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

    }
}
