#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ProjectileData`. Inherits from `AtomDrawer&lt;ProjectileDataEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ProjectileDataEvent))]
    public class ProjectileDataEventDrawer : AtomDrawer<ProjectileDataEvent> { }
}
#endif
