using System;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
    private static readonly Dictionary<Type, object> _services = new();
  
    public static void Register<T>(T service)
    {
        var type = typeof(T);

        if (_services.ContainsKey(type))
        {
            Debug.LogWarning($"ServiceLocator: {type.Name} zaten kayıtlı.");
            return;
        }

        _services[type] = service;
    }
  
    public static T Get<T>()
    {
        var type = typeof(T);

        if (_services.TryGetValue(type, out var service))
            return (T)service;

        throw new Exception($"ServiceLocator: {type.Name} servisi bulunamadı.");
    }
  
    public static void Unregister<T>()
    {
        var type = typeof(T);
        _services.Remove(type);
    }
  
    public static void Clear() => _services.Clear();
}
