#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `LaserBeamData`. Inherits from `AtomEventEditor&lt;LaserBeamData, LaserBeamDataEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LaserBeamDataEvent))]
    public sealed class LaserBeamDataEventEditor : AtomEventEditor<LaserBeamData, LaserBeamDataEvent> { }
}
#endif
