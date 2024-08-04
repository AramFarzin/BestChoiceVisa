using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Domain.ValueObjects;
public record ContactInfo(string PhoneNumber, EmailAddress EmailAddress, Website Website, string Fax);