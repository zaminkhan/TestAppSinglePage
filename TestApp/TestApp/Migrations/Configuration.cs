namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using TestApp.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<TestApp.DAL.ImageDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        public byte[] GetAlertImage()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Migrations/Dummy.jpg";

            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(path);

            return bytes;
        }

        protected override void Seed(TestApp.DAL.ImageDB context)
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

            var image = GetAlertImage();

            context.ImagesForTests.AddOrUpdate(
              m => m.Title,
              new ImagesForTest
              {
                  Title = "Image 1",
                  description = "Image 1 description",
                  image = image
              },
              new ImagesForTest
              {
                  Title = "Image 2",
                  description = "Image 2 description",
                  image = image
              },
              new ImagesForTest
              {
                  Title = "Image 3",
                  description = "Image 3 description",
                  image = image
              },
              new ImagesForTest
              {
                  Title = "Image 4",
                  description = "Image 4 description",
                  image = image
              });
        }
    }
}
