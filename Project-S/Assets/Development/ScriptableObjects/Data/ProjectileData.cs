using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(fileName = "NewProjectileData", menuName = "Projectile Data")]
public class ProjectileData : ScriptableObject
{
    public FloatVariableInstancer speed;
    public FloatVariableInstancer damage;
    public GameObject prefab;
    public LayerMask targetLayer;
}
