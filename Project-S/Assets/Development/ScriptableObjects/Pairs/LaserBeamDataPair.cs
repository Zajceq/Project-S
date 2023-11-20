using System;
using UnityEngine;
namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// IPair of type `&lt;LaserBeamData&gt;`. Inherits from `IPair&lt;LaserBeamData&gt;`.
    /// </summary>
    [Serializable]
    public struct LaserBeamDataPair : IPair<LaserBeamData>
    {
        public LaserBeamData Item1 { get => _item1; set => _item1 = value; }
        public LaserBeamData Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private LaserBeamData _item1;
        [SerializeField]
        private LaserBeamData _item2;

        public void Deconstruct(out LaserBeamData item1, out LaserBeamData item2) { item1 = Item1; item2 = Item2; }
    }
}