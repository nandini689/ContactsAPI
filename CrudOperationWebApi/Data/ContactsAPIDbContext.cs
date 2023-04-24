using CrudOperationWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationWebApi.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
