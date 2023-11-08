#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ProjectileDataPair`. Inherits from `AtomEventEditor&lt;ProjectileDataPair, ProjectileDataPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ProjectileDataPairEvent))]
    public sealed class ProjectileDataPairEventEditor : AtomEventEditor<ProjectileDataPair, ProjectileDataPairEvent> { }
}
#endif
