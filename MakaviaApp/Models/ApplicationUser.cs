using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakaviaApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(3)]
        public List<Character> Characters { get; set; }
    }
}
