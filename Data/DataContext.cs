﻿using AutoMailSender.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.EntityFrameworkCore.Design;
using AutoMailSender.Services.EmailService;

namespace AutoMailSender.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<EmailDto> EmailDto { get; set; }
    

    }

}
