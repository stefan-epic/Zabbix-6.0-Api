namespace Zabbix.Filter;

public class BaseEntity
{
    public enum test
    {
        A,
        B,
        C
    }


    // Base class implementation
}

public class Derived : BaseEntity
{
    public new enum test
    {
        D,
        E,
        F
    }
}

public class Test<Entity>
    where Entity : BaseEntity
{
}