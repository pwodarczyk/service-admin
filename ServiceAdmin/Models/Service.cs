using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ServiceAdmin.Models
{
   public class Service
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Industry industry { get; set; }
    }

}