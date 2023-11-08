using UnityEngine;
using System;
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
        public float speed;
        public float damage;
        public Projectile projectilePrefab;
        public LayerMask targetLayer;

        protected override bool ValueEquals(ProjectileData other)
        {
            throw new NotImplementedException();
        }
    }
}
