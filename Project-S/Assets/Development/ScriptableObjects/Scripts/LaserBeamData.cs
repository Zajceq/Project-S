using UnityEngine;

[System.Serializable]
public struct LaserBeamData
{
    public float BeamLength;
    public float BeamWidth;
    public float Damage;
    public LayerMask TargetLayer;
}
