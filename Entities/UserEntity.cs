﻿using System.ComponentModel.DataAnnotations;

namespace IdentityPractice.Entities
{
    public class UserEntity
    {
        public UserEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
