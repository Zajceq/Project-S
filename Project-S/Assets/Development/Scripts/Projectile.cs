using UnityEngine;
using UnityAtoms.MyAtoms;

public class Projectile : MonoBehaviour
{
    [SerializeField] protected ProjectileDataVariable projectileData;

    protected bool isActive = false;

    private void Update()
    {
        if (isActive)
        {
            transform.Translate(Vector3.up * projectileData.speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == projectileData.targetLayer)
        {
            if (other.gameObject.TryGetComponent<Damageable>(out Damageable damageable))
            {
                damageable.ReceiveDamage(projectileData.damage);
            }

            if (PoolingManager.Instance.GetPool(projectileData.projectilePrefab.gameObject) != null)
            {
                PoolingManager.Instance.GetPool(projectileData.projectilePrefab.gameObject).ReturnToPool(projectileData.projectilePrefab.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

            isActive = false;
        }
    }
}