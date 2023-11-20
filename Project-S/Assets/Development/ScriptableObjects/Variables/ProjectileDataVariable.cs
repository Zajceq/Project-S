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
            return this.Value.Speed == other.Speed &&
                   this.Value.Damage == other.Damage &&
                   this.Value.ProjectilePrefab == other.ProjectilePrefab &&
                   this.Value.TargetLayer == other.TargetLayer;
        }
    }
}