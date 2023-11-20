using UnityEngine;

namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// Event of type `LaserBeamData`. Inherits from `AtomEvent&lt;LaserBeamData&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/LaserBeamData", fileName = "LaserBeamDataEvent")]
    public sealed class LaserBeamDataEvent : AtomEvent<LaserBeamData>
    {
    }
}
