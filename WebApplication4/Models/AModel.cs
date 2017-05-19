using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class AModel : DbContext
    {
        public int Pid { get; set; }
    }
}