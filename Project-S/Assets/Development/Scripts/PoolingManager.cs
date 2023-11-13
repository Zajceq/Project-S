using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : Singleton<PoolingManager>
{
    private Dictionary<string, PrefabPool> pools = new Dictionary<string, PrefabPool>();

    public PrefabPool CreatePool(GameObject prefab, int initialSize)
    {
        if (prefab == null)
        {
            Debug.LogError("Prefab is null");
            return null;
        }

        if (pools.ContainsKey(prefab.name))
        {
            Debug.LogWarning("Pool for prefab " + prefab.name + " already exists. Returning existing pool.");
            return pools[prefab.name];
        }

        PrefabPool pool = new PrefabPool(prefab);
        for (int i = 0; i < initialSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.AddToPool(obj);
        }

        pools.Add(prefab.name, pool);
        return pool;
    }

    public PrefabPool GetPool(GameObject prefab)
    {
        if (prefab == null)
        {
            Debug.LogError("Prefab is null");
            return null;
        }

        if (pools.ContainsKey(prefab.name))
        {
            return pools[prefab.name];
        }

        return null;
    }
}