using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hatiku.Models
{
    public class Admin
    {
        private int id;
        private string username;
        private string password;

        [DisplayName("Admin Id")]
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        [Required(ErrorMessage="Username is required")]
        [StringLength(50, MinimumLength=8, ErrorMessage="Username must between 8 and 50 characters")]
        public string Username 
        { 
            get => username; 
            set => username = value; 
        }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Username must between 8 and 50 characters")]
        public string Password 
        { 
            get => password;
            set => password = value; 
        }


    }
}
