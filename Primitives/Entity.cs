using System.ComponentModel.DataAnnotations;

namespace Domain.Primitives;
public abstract class Entity
{
    [Key]
    [Required]
    public EntityId Id { get; protected set; }

    protected Entity(EntityId id) => Id=id;
}