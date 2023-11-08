#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ProjectileData`. Inherits from `AtomEventEditor&lt;ProjectileData, ProjectileDataEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ProjectileDataEvent))]
    public sealed class ProjectileDataEventEditor : AtomEventEditor<ProjectileData, ProjectileDataEvent> { }
}
#endif
