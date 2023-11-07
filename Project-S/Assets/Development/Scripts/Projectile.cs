using UnityEngine;

public class Projectile : MonoBehaviour
{
    public ProjectileData projectileData;

    private void Update()
    {
        transform.Translate(Vector3.forward * projectileData.speed.Value * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == projectileData.targetLayer)
        {
            if (other.gameObject.TryGetComponent<Damageable>(out Damageable damageable))
            {
                damageable.ReceiveDamage(projectileData.damage.Value);
                if (PoolingManager.Instance.GetPool(projectileData.prefab) != null)
                {
                    PoolingManager.Instance.GetPool(projectileData.prefab).ReturnToPool(projectileData.prefab);
                }
                else
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}