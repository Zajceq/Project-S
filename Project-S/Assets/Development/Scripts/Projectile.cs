using UnityEngine;
using UnityAtoms.MyAtoms;

public class Projectile : MonoBehaviour
{
    [SerializeField] public ProjectileDataVariable projectileData;

    private void Update()
    {
        transform.Translate(Vector3.up * projectileData.Value.speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if ((projectileData.Value.targetLayer.value & (1 << other.gameObject.layer)) != 0)
        {
            if (other.gameObject.TryGetComponent<Damageable>(out Damageable damageable))
            {
                damageable.ReceiveDamage(projectileData.Value.damage);
                Debug.Log("Damaged");
            }

            if (PoolingManager.Instance.GetPool(projectileData.Value.projectilePrefab.gameObject) != null)
            {
                PoolingManager.Instance.GetPool(projectileData.Value.projectilePrefab.gameObject).ReturnToPool(projectileData.Value.projectilePrefab.gameObject);
                Debug.Log("ReturnToPool");
            }
            else
            {
                Destroy(this.gameObject);
                Debug.Log("Destroy");
            }
        }
    }
}