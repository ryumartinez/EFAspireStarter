using Microsoft.EntityFrameworkCore;
using AT.Access.Common.Domain;

namespace AT.Access.Common;

public class ATDbContext : DbContext
{
    public ATDbContext(DbContextOptions<ATDbContext> options) : base(options) { }
    public DbSet<Address> Address { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<Country> Country { get; set; }
    public DbSet<PersonEmail> PersonEmail { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<PersonDocument> PersonDocument { get; set; }
    public DbSet<PersonTechnology> PersonTechnology { get; set; }
    public DbSet<PersonLanguages> PersonLanguages { get; set; }
    public DbSet<Phone> Phone { get; set; }
    public DbSet<PhoneServices> PhoneServices { get; set; }
    public DbSet<PhoneType> PhoneType { get; set; }
    public DbSet<SocialMediaProfile> SocialMediaProfile { get; set; }
    public DbSet<SocialMediaType> SocialMediaType { get; set; }
    public DbSet<State> State { get; set; }
    public DbSet<TechnologyType> TechnologyType { get; set; }
}