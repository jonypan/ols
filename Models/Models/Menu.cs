using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.Models
{
    public class Menu
    {
        public int FunctionID { set; get; }
        public string FunctionName { set; get; }
        public string Url { set; get; }
        public string Code { set; get; }
        public bool IsInsert { set; get; }
        public bool IsUpdate { set; get; }
        public bool IsDelete { set; get; }
        public int FatherID { set; get; }
        public int OrderID { set; get; }
    }
}