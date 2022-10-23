using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class User
    {
        public int Userid { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Cellnumber { get; set; } = string.Empty;
        public string Emailid { get; set; } = string.Empty;
    }
}
