﻿using System.ComponentModel.DataAnnotations;




namespace AutoMailSender.Models
{
    public class EmailDto
    {
  
        public int Id { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Recepients { get; set; } = string.Empty;
        public DateTime TimeCreated { get; set; }
       
        [Required]
        public int StatusCode { get; set; }
        [Required]
        public string StatusMessage { get; set; }
        




    }
}
