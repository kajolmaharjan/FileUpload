using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileUploadTest.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public HttpPostedFile ImageFile { get; set; }
    }
}