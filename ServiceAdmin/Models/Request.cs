using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ServiceAdmin.Models
{
   public class Request
    {
        public int ID { get; set; }
        public string userEmail { get; set; }
        public string userName { get; set; }
        public Service service { get; set; }
        public string description { get; set; }
        public int numberPurchased { get; set; }
        public int status { get; set; }
    }
    
}