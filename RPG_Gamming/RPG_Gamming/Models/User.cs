﻿namespace RPG_Gamming.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Character>? Characters { get; set; }
        //public User? user { get; set; }

    }
}
