using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// Variable of type `LaserBeamData`. Inherits from `AtomVariable&lt;LaserBeamData, LaserBeamDataPair, LaserBeamDataEvent, LaserBeamDataPairEvent, LaserBeamDataLaserBeamDataFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/LaserBeamData", fileName = "LaserBeamDataVariable")]
    public sealed class LaserBeamDataVariable : AtomVariable<LaserBeamData, LaserBeamDataPair, LaserBeamDataEvent, LaserBeamDataPairEvent, LaserBeamDataLaserBeamDataFunction>
    {
        protected override bool ValueEquals(LaserBeamData other)
        {
            return this.Value.BeamLength == other.BeamLength &&
                   this.Value.BeamWidth == other.BeamWidth &&
                   this.Value.Damage == other.Damage &&
                   this.Value.TargetLayer == other.TargetLayer;
        }
    }
}
