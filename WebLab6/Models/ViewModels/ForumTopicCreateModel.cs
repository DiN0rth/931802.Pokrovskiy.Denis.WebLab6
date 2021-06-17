using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebLab6.Models.ViewModels
{
    public class ForumTopicCreateModel
    {
        public DateTime Created { get; set; }
        [Required]
        public String Name { get; set; }
    }
}
