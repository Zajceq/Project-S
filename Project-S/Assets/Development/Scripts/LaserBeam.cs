using UnityEngine;
using UnityAtoms.MyAtoms;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeam : MonoBehaviour
{
    [SerializeField] private LaserBeamDataVariable _laserBeamData;

    private LineRenderer _lineRenderer;
    private bool _isActive = false;

    private void Start()
    {
        if (_lineRenderer == null)
        {
            _lineRenderer = GetComponent<LineRenderer>();
        }

        _lineRenderer.startWidth = _laserBeamData.Value.BeamWidth;
        _lineRenderer.endWidth = _laserBeamData.Value.BeamWidth;
        _lineRenderer.enabled = false;

        Activate();
    }

    public void Activate()
    {
        _isActive = true;
        _lineRenderer.enabled = true;
        UpdateBeam();
    }

    public void Deactivate()
    {
        _isActive = false;
        _lineRenderer.enabled = false;
    }

    private void Update()
    {
        if (_isActive)
        {
            UpdateBeam();
        }
    }

    private void UpdateBeam()
    {
        RaycastHit hit;
        Vector3 endPosition = transform.position + transform.up * _laserBeamData.Value.BeamLength;

        if (Physics.Raycast(transform.position, transform.up, out hit, _laserBeamData.Value.BeamLength, _laserBeamData.Value.TargetLayer))
        {
            endPosition = hit.point;

            Damageable damageable = hit.collider.GetComponent<Damageable>();
            if (damageable != null)
            {
                damageable.ReceiveDamage(_laserBeamData.Value.Damage);
            }
        }

        _lineRenderer.SetPosition(0, transform.position);
        _lineRenderer.SetPosition(1, endPosition);
    }
}