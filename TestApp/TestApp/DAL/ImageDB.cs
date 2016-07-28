using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestApp.DAL
{
    public class ImageDB: DbContext
    {
        public ImageDB()
            : base("DefaultConnection") 
    {
        Database.SetInitializer(new MigrateDatabaseToLatestVersion<ImageDB, TestApp.Migrations.Configuration>("DefaultConnection"));
            
    }
        public DbSet<ImagesForTest> ImagesForTests { get; set; }
    } 

}