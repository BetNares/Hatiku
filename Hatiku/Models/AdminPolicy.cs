using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models
{
    public class AdminPolicy
    {
        [DisplayName("Admin Id")]
        public int UserId { get; set; }

        public int PolicyId { get; set; }
    }
}
