#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `LaserBeamData`. Inherits from `AtomDrawer&lt;LaserBeamDataVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LaserBeamDataVariable))]
    public class LaserBeamDataVariableDrawer : VariableDrawer<LaserBeamDataVariable> { }
}
#endif
