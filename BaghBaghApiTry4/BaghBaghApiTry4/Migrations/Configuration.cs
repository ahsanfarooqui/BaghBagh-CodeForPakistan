namespace BaghBaghApiTry4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaghBaghApiTry4.Models.BaghBaghApiTry4Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BaghBaghApiTry4.Models.BaghBaghApiTry4Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.BaseUsers.AddOrUpdate(
                x => x.Id,
                new Models.BaseUser() { Email = "asdasf", Name = "Hello World", Id = 1 },
                new Models.BaseUser() { Email = "asdasf", Name = "Hello World", Id = 2 },
                new Models.BaseUser() { Email = "asdasf", Name = "Hello World", Id = 3 }
                );

            context.BasePlants.AddOrUpdate(x => x.Id,
                new Models.BasePlant { Catagory = "fdafd", Id = 0, DateStamp = "asfas", Name = "adfs",  ImagePath = "~/App_Data/img"},
                new Models.BasePlant { Catagory = "fdafd", Id = 0, DateStamp = "asfas", Name = "adfs",  },
                new Models.BasePlant { Catagory = "fdafd", Id = 0, DateStamp = "asfas", Name = "adfs",  }
                );
        }
    }
}
