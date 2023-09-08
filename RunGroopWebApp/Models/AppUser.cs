using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RunGroopWebApp.Models;

public class AppUser : IdentityUser
{
    [Key]
    public string Id { get; set; }
    public int? Pace { get; set; }
    public int? Mileage { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }
    public ICollection<Club> Clubs { get; set; }
    public ICollection<Race> Races { get; set; }
}