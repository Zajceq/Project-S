using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour, ISpawnable
{
    [SerializeField] private float _spawnChance;

    public float SpawnChance
    {
        get { return _spawnChance; }
    }

}
