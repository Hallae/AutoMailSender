﻿namespace AutoMailSender.Models
{
    public class EmailDto
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Recepients { get; set; } = string.Empty;
    }
}
