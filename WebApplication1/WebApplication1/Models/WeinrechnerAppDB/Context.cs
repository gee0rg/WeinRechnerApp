using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.WeinrechnerAppDB
{
    public class Context : DbContext
    {
    
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Context() : base("name=Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.User> User { get; set; }
    }
}
