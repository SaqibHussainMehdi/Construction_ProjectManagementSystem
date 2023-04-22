﻿using System.ComponentModel.DataAnnotations;

namespace Construction_Company.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public DateTime date { get; set; }
       
        [MaxLength(100)]
        public string PayDesc { get; set; }
       
        public int Paid { get; set; }
        public ProjectAssignment projectAssignment { get; set; }
    }
}
