using System;
using UnityEngine;
namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// IPair of type `&lt;ProjectileData&gt;`. Inherits from `IPair&lt;ProjectileData&gt;`.
    /// </summary>
    [Serializable]
    public struct ProjectileDataPair : IPair<ProjectileData>
    {
        public ProjectileData Item1 { get => _item1; set => _item1 = value; }
        public ProjectileData Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ProjectileData _item1;
        [SerializeField]
        private ProjectileData _item2;

        public void Deconstruct(out ProjectileData item1, out ProjectileData item2) { item1 = Item1; item2 = Item2; }
    }
}