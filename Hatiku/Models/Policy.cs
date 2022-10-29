using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hatiku.Models
{
    [Table("Policy")]
    public class Policy
    {
        private int policyId;
        private string name;
        private string detail;

        [DisplayName("Policy Id")]
        [Required(ErrorMessage = "Username is required")]
        [Key]
        public int PolicyId
        {
            get => policyId;
            set => policyId = value;
        }

        [DisplayName("Policy Name")]
        [Required(ErrorMessage = "Policy Name is required")]
        [StringLength(maximumLength:50, MinimumLength=8, ErrorMessage= "Policy name must between 8 and 50 characters")]
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        [DisplayName("Policy detail information")]
        public string Detail 
        { 
            get => detail; 
            set => detail = value; 
        }
    }
}
