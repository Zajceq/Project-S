using UnityEngine;
using System.Collections.Generic;

public class PrefabPool
{
    private Stack<GameObject> pool = new Stack<GameObject>();
    private GameObject prefab;

    public PrefabPool(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void AddToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Push(obj);
    }

    public GameObject GetFromPool()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Pop();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            GameObject obj = GameObject.Instantiate(prefab);
            obj.SetActive(true);
            return obj;
        }
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Push(obj);
    }
}