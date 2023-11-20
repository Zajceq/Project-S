using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `LaserBeamData`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(LaserBeamDataVariable))]
    public sealed class LaserBeamDataVariableEditor : AtomVariableEditor<LaserBeamData, LaserBeamDataPair> { }
}
