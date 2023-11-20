#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `LaserBeamDataPair`. Inherits from `AtomEventEditor&lt;LaserBeamDataPair, LaserBeamDataPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LaserBeamDataPairEvent))]
    public sealed class LaserBeamDataPairEventEditor : AtomEventEditor<LaserBeamDataPair, LaserBeamDataPairEvent> { }
}
#endif
