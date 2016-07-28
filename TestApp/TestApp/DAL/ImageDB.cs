using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestApp.DAL
{
    public class TestImageDB: DbContext
    {
        public TestImageDB()
            : base("DefaultConnection") 
    {
        Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestImageDB, TestApp.Migrations.Configuration>("DefaultConnection"));
            
    }
        public DbSet<ImagesForTest> ImagesForTests { get; set; }
    } 

}