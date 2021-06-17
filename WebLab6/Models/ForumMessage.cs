﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebLab6.Models
{
    public class ForumMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ForumTopicId { get; set; }
        [Required]
        public String ApplicationUserId { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        [Required]
        public String Text { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public ForumTopic ForumTopic { get; set; }
        public ICollection<ForumMessageAttachment> ForumMessageAttachments { get; set; }
    }
}
