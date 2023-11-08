#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.MyAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `ProjectileData`. Inherits from `AtomDrawer&lt;ProjectileDataVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ProjectileDataVariable))]
    public class ProjectileDataVariableDrawer : VariableDrawer<ProjectileDataVariable> { }
}
#endif
