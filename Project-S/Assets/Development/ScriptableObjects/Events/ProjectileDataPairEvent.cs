using UnityEngine;

namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// Event of type `ProjectileDataPair`. Inherits from `AtomEvent&lt;ProjectileDataPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ProjectileDataPair", fileName = "ProjectileDataPairEvent")]
    public sealed class ProjectileDataPairEvent : AtomEvent<ProjectileDataPair>
    {
    }
}
