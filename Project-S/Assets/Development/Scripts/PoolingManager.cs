using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : Singleton<PoolingManager>
{
    private Dictionary<string, PoolPrefab> pools = new Dictionary<string, PoolPrefab>();

    public PoolPrefab CreatePool(GameObject prefab, int initialSize)
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

        PoolPrefab pool = new PoolPrefab(prefab);
        for (int i = 0; i < initialSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.AddToPool(obj);
        }

        pools.Add(prefab.name, pool);
        return pool;
    }

    public PoolPrefab GetPool(GameObject prefab)
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