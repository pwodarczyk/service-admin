using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace ServiceAdmin.Models
{
   public class Business
    {
        public int ID { get; set; }
        public string name { get; set; }
        public virtual ICollection<Service> Services { get; set; }

    }
    
}