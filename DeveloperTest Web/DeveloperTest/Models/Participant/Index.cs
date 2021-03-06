﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperTest.Models.Participant
{
    public class Index
    {
        public int ParticipantId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string Zip { get; set; }

        public string Email { get; set; }
    }
}