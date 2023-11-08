using UnityEngine;

namespace UnityAtoms.MyAtoms
{
    /// <summary>
    /// Event of type `ProjectileData`. Inherits from `AtomEvent&lt;ProjectileData&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ProjectileData", fileName = "ProjectileDataEvent")]
    public sealed class ProjectileDataEvent : AtomEvent<ProjectileData>
    {
    }
}
