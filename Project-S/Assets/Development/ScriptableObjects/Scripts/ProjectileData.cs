using Unity.VisualScripting;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[System.Serializable]
public struct ProjectileData
{
    public float speed;
    public float damage;
    public GameObject projectilePrefab;
    public LayerMask targetLayer;
}
