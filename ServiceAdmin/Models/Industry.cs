using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ServiceAdmin.Models
{
   public class Industry   {
        public int ID { get; set; }
        public string name { get; set; }
      
    }
    
}