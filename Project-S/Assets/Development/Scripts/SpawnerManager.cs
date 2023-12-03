using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public List<Spawner> spawners;

    public void EnableSpawning(bool enable)
    {
        foreach (var spawner in spawners)
        {
            spawner.enabled = enable;
        }
    }
}
