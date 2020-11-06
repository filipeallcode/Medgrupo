using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;

namespace Contacts
{
    public class ContactsContext : DbContext
    {
        public DbSet<ContactViewModel> ContactViewModel { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=contacts.db");
    }
}