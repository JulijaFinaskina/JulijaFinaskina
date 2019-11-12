using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sludinajumu_Portals_NET_BC.Models
{
    public class SignUpModel : UserModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(PasswordRepeat))]
        public string PasswordRepeat { get; set; }
    }
}
