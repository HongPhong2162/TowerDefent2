using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T : new() 
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }
}

public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static bool IsInstanceInvalid()
    {
        return instance != null;
    }


    public static T Instance
    {
        get
        {
            if (instance != null)
                return instance;
            instance = FindFirstObjectByType<T>();

            if (instance != null)
                return instance;
            Debug.Log($"Not found Object for type {typeof(T).Name}");
            return instance;
        }
    }
}
