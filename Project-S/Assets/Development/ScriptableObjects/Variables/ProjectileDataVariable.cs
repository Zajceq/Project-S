using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// Variable of type `ProjectileData`. Inherits from `AtomVariable&lt;ProjectileData, ProjectileDataPair, ProjectileDataEvent, ProjectileDataPairEvent, ProjectileDataProjectileDataFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ProjectileData", fileName = "ProjectileDataVariable")]
    public sealed class ProjectileDataVariable : AtomVariable<ProjectileData, ProjectileDataPair, ProjectileDataEvent, ProjectileDataPairEvent, ProjectileDataProjectileDataFunction>
    {
        protected override bool ValueEquals(ProjectileData other)
        {
            return this.Value.speed == other.speed &&
                   this.Value.damage == other.damage &&
                   this.Value.projectilePrefab == other.projectilePrefab &&
                   this.Value.targetLayer == other.targetLayer;
        }
    }
}