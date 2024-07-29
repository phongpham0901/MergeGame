using System;
using System.Collections.Generic;

public class Container
{
    private static readonly Dictionary<Type, Type> typeMapping = new Dictionary<Type, Type>();
    private static readonly Dictionary<Type, object> instanceMapping = new Dictionary<Type, object>();

    public static void Register<TInterface, TImplementation>() where TImplementation : TInterface
    {
        typeMapping[typeof(TInterface)] = typeof(TImplementation);
    }

    public static void RegisterSingleton<TInterface>(TInterface instance)
    {
        instanceMapping[typeof(TInterface)] = instance;
    }

    public static TInterface Resolve<TInterface>()
    {
        if (instanceMapping.TryGetValue(typeof(TInterface), out var instance))
        {
            return (TInterface)instance;
        }

        if (typeMapping.TryGetValue(typeof(TInterface), out var implementationType))
        {
            var implementationInstance = Activator.CreateInstance(implementationType);
            instanceMapping[typeof(TInterface)] = implementationInstance;
            return (TInterface)implementationInstance;
        }

        throw new Exception($"Không có đăng ký cho {typeof(TInterface)}");
    }
}