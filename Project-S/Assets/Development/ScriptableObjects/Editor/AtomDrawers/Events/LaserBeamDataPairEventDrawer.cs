#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `LaserBeamDataPair`. Inherits from `AtomDrawer&lt;LaserBeamDataPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LaserBeamDataPairEvent))]
    public class LaserBeamDataPairEventDrawer : AtomDrawer<LaserBeamDataPairEvent> { }
}
#endif
