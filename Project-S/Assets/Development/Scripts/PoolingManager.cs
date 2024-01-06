using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : Singleton<PoolingManager>
{
    private Dictionary<string, PoolPrefab> pools = new Dictionary<string, PoolPrefab>();

    public PoolPrefab CreatePool(GameObject prefab, int initialSize)
    {
        string prefabName = prefab.name.Replace("(Clone)", "");

        if (prefab == null)
        {
            Debug.LogError("Prefab is null");
            return null;
        }

        if (pools.ContainsKey(prefabName))
        {
            Debug.LogWarning("Pool for prefab " + prefabName + " already exists. Returning existing pool.");
            return pools[prefabName];
        }

        PoolPrefab pool = new PoolPrefab(prefab);
        for (int i = 0; i < initialSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.AddToPool(obj);
        }

        pools.Add(prefabName, pool);
        return pool;
    }

    public PoolPrefab GetPool(GameObject prefab)
    {
        string prefabName = prefab.name.Replace("(Clone)", "");

        if (prefab == null)
        {
            Debug.LogError("Prefab is null");
            return null;
        }

        if (pools.ContainsKey(prefabName))
        {
            return pools[prefabName];
        }

        return null;
    }
}