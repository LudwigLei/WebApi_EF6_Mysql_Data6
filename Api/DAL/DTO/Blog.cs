using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.DAL.DTO
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Content { get; set; } // test migration for blog table
    }
}