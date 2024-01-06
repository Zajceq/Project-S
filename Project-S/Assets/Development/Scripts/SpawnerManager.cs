using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public List<Spawner> spawners;

    private void Start()
    {
        foreach (Spawner spawner in spawners)
        {
            foreach (var obj in spawner.SpawnableObjects)
            {
                if (PoolingManager.Instance.GetPool(obj) == null)
                {
                    PoolingManager.Instance.CreatePool(obj, 15);
                }
            }
        }
    }

    public void EnableSpawning(bool enable)
    {
        foreach (var spawner in spawners)
        {
            spawner.enabled = enable;
        }
    }
}
