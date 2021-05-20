using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonObject<T> : MonoBehaviour
{
    public static T Instance { get; private set; }

   protected void SetupSingleTon(T entity) //Protected:hem kendi hemde miras verilende erişilir.
    {
        if (Instance == null)
        {
            Instance = entity ;
            DontDestroyOnLoad(this.gameObject);
        }
        else {
            Destroy(this.gameObject);
        }
    }
}
