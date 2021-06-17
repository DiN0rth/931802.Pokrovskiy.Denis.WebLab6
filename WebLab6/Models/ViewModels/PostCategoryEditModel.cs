using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebLab6.Models.ViewModels
{
    public class PostCategoryEditModel
    {
        [Required]
        [MaxLength(200)]
        public String Name { get; set; }
    }
}
