﻿using System;

namespace Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Nickname { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
