namespace Zabbix.Entities;

public abstract class BaseEntity
{
    public virtual string? EntityId { get; set; }

    public override string ToString()
    {
        return $"{nameof(EntityId)}: {EntityId}";
    }
}