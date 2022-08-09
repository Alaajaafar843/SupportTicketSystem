using Microsoft.EntityFrameworkCore;
using SupportTicket.Models;

namespace dotnet;
public class MySQLDBContext : DbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Client> Clients { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options) { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
