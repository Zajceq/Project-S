using UnityEngine;

[System.Serializable]
public struct ProjectileData
{
    public float Speed;
    public float Damage;
    public GameObject ProjectilePrefab;
    public LayerMask TargetLayer;
}
