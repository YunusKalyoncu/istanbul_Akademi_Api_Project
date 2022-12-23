using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace istanbul_Akademi_Api_Project.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
