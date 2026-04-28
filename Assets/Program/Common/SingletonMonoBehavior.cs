using System;
using UnityEngine;

public class SingletonMonoBehavior<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType<T>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(this != Instance)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }
}
