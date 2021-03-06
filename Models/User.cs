using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string Nama_Lengkap { get; set; }
        public string Password { get; set; }
        public string No_Telp { get; set; }
        public string Alamat { get; set; }
        public string RolesId { get; set; }

        [ForeignKey("RolesId")]
        public Roles FkRoles { get; set; }
    }
}
