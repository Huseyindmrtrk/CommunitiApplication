using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace CommunitiApp.Models
{
    public class SubCommuniti
    {
        public int Id { get; set; }
        public string SubCommunitiName { get; set; }
        public bool IsDeleted { get; set; }
    }
}