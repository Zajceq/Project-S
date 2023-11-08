using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `ProjectileData`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ProjectileDataVariable))]
    public sealed class ProjectileDataVariableEditor : AtomVariableEditor<ProjectileData, ProjectileDataPair> { }
}
