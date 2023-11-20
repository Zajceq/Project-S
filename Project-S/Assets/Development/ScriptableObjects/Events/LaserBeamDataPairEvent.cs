using UnityEngine;

namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// Event of type `LaserBeamDataPair`. Inherits from `AtomEvent&lt;LaserBeamDataPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/LaserBeamDataPair", fileName = "LaserBeamDataPairEvent")]
    public sealed class LaserBeamDataPairEvent : AtomEvent<LaserBeamDataPair>
    {
    }
}
