using UnityEngine;
using UnityAtoms.MyAtoms;

public class Projectile : MonoBehaviour
{
    [SerializeField] public ProjectileDataVariable projectileData;

    private void Update()
    {
        transform.Translate(Vector3.up * projectileData.Value.Speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if ((projectileData.Value.TargetLayer.value & (1 << other.gameObject.layer)) != 0)
        {
            if (other.gameObject.TryGetComponent<Damageable>(out Damageable damageable))
            {
                damageable.ReceiveDamage(projectileData.Value.Damage);
                Debug.Log("Damaged");
            }

            if (PoolingManager.Instance.GetPool(projectileData.Value.ProjectilePrefab.gameObject) != null)
            {
                PoolingManager.Instance.GetPool(projectileData.Value.ProjectilePrefab.gameObject).ReturnToPool(this.gameObject);
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