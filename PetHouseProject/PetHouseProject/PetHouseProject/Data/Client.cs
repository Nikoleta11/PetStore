﻿namespace PetHouseProject.Data;
    using Microsoft.AspNetCore.Identity;

    public class Client:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

