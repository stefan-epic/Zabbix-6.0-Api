using Zabbix.Entities;

namespace Zabbix.Helpers
{
    public static class Checker
    {
        public static IEnumerable<T> ReturnEmptyListOrActual<T>(IEnumerable<T>? objects)
        {
            if (objects == null)
                return new List<T>();
            return objects;
        }
        public static string ReturnEmptyStringOrActual(string? str)
        {
            return str ?? string.Empty;
        }

        public static void CheckEntityId(BaseEntity entity)
        {
            if (entity.EntityId == null)
            {
                throw new NullReferenceException($"ID cannot be null for {entity}");
            }
        }
        public static void CheckEntityId(string? id)
        {
            if (id == null)
            {
                throw new NullReferenceException($"ID cannot be null");
            }
        }
        public static void CheckEntityIds(IEnumerable<string?> ids)
        {
            if (ids.Any(id => id == null))
            {
                throw new NullReferenceException($"ID cannot be null");
            }
        }
        public static void CheckEntityIds(IEnumerable<BaseEntity> entities)
        {

            foreach (var e in entities)
            {
                CheckEntityId(e);
            }
        }
    }
}
