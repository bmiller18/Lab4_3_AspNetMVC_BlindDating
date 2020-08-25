﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab4_3_AspNetMVC_BlindDating.Models
{
    public partial class DatingProfile
    {
        public DatingProfile()
        {
            MailMessageFromProfile = new HashSet<MailMessage>();
            MailMessageToProfile = new HashSet<MailMessage>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string UserAccountId { get; set; }
        [Required]
        public string DisplayName { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<MailMessage> MailMessageFromProfile { get; set; }
        public ICollection<MailMessage> MailMessageToProfile { get; set; }
    }
}
