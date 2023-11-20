#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `LaserBeamData`. Inherits from `AtomDrawer&lt;LaserBeamDataEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LaserBeamDataEvent))]
    public class LaserBeamDataEventDrawer : AtomDrawer<LaserBeamDataEvent> { }
}
#endif
