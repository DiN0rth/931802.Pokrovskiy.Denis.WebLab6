using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebLab6.Models
{
    public class ForumMessageAttachment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ForumMessageId { get; set; }

        public DateTime Created { get; set; }
        [Required]
        public String FileName { get; set; }
        [Required]
        public String FilePath { get; set; }

        public ForumMessage ForumMessage { get; set; }
    }
}
