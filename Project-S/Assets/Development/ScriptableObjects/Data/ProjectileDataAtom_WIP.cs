using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using System;

[EditorIcon("atom-icon-lush")]
[CreateAssetMenu(menuName = "UnityAtoms/Data/Projectile Data", fileName = "NewProjectileData")]
public class ProjectileDataAtom_WIP : IEquatable<ProjectileData>
{
    [SerializeField] private FloatVariableInstancer speed;

    [SerializeField] private FloatVariableInstancer damage;

    [SerializeField] private GameObject prefab;

    [SerializeField] private LayerMask targetLayer;

    public bool Equals(ProjectileData other)
    {
        var data = ScriptableObject.CreateInstance<ProjectileData>();
        data.speed = speed;
        data.damage = damage;
        data.prefab = prefab;
        data.targetLayer = targetLayer;
        return data == other;
    }

    public override bool Equals(object obj)
    {
        return Equals((ProjectileData)obj);
    }

    public override int GetHashCode()
    {
        var data = ScriptableObject.CreateInstance<ProjectileData>();
        data.speed = speed;
        data.damage = damage;
        data.prefab = prefab;
        data.targetLayer = targetLayer;
        return data.GetHashCode();
    }
}

