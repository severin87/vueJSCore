﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Entities.Identity
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
