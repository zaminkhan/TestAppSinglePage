using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.DAL
{
    public class ImagesForTest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }
    }
}