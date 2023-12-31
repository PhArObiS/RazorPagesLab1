﻿namespace Lab1Neil.Models
{
    public class Student
    {
        public string StudentNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public string Image { get; set; }

        public Student(string studentNumber, string fullName, string email, string password, string picture)
        {
            StudentNumber = studentNumber;
            FullName = fullName;
            Email = email;
            Password = password;
            Image = picture;
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }
}
