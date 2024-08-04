

using System.ComponentModel.DataAnnotations;
using Domain.Entities;

public record ContactInfo(string PhoneNumber, EmailAddress EmailAddress, string Website, string Fax);