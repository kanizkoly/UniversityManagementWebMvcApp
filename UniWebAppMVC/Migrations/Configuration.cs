using UniWebAppMVC.Models;

namespace UniWebAppMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UniWebAppMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UniWebAppMVC.Models.ProjectDB>
    {
        private readonly bool _pendingMigrations;
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;

            // If you want automatic migrations the uncomment the line below.
            //AutomaticMigrationsEnabled = true;
            var migrator = new DbMigrator(this);
            _pendingMigrations = migrator.GetPendingMigrations().Any();
        }

        protected override void Seed(UniWebAppMVC.Models.ProjectDB context)
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

            if (!_pendingMigrations) return;

            context.Semesters.AddOrUpdate(x => x.SemesterId,
            new Semester() { SemesterId = 1, Name = "1.1" },
            new Semester() { SemesterId = 2, Name = "1.2" },
            new Semester() { SemesterId = 3, Name = "2.1" },
            new Semester() { SemesterId = 2, Name = "2.2" },
            new Semester() { SemesterId = 2, Name = "3.1" },
            new Semester() { SemesterId = 2, Name = "3.2" },
            new Semester() { SemesterId = 2, Name = "4.1" },
            new Semester() { SemesterId = 2, Name = "4.2" }
        );

            context.Designations.AddOrUpdate(x => x.DesignationId,
              new Designation() { DesignationId = 1, Name = "Professor" },
              new Designation() { DesignationId = 1, Name = "Assistans Professor" },
              new Designation() { DesignationId = 1, Name = "Lecturer" }
              
              );

        }
    }
}
