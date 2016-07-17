using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaghBaghApiTry4.Models
{
    public class BaghBaghApiTry4Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BaghBaghApiTry4Context() : base("name=BaghBaghApiTry4Context")
        {
        }

        public System.Data.Entity.DbSet<BaghBaghApiTry4.Models.BasePlant> BasePlants { get; set; }

        public System.Data.Entity.DbSet<BaghBaghApiTry4.Models.BaseUser> BaseUsers { get; set; }
    }
}
