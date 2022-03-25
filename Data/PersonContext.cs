using efdemo.Models;
using Microsoft.EntityFrameworkCore;

public class PeopleContext : DBContext {
    public DbSet<Person> Person { get; set; }
}