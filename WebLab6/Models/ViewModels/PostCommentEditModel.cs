using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebLab6.Models.ViewModels
{
    public class PostCommentEditModel
    {
        [Required]
        public String Text { get; set; }
    }
}
