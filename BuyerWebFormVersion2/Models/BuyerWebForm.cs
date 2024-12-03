using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BuyerWebFormVersion2.Models
{
    [Collection("Test")]
    public class BuyerWebForm
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
