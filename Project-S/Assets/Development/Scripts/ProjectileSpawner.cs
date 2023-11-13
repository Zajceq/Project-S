using System.Collections;
using UnityEngine;
using UnityAtoms.MyAtoms;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private float shootingDelay;

    [SerializeField] private bool canShoot;

    private PrefabPool _pool;

    private void Start()
    {
        _pool = PoolingManager.Instance.CreatePool(projectile.projectileData.Value.projectilePrefab.gameObject, 50);

        StartCoroutine(ShootingCoroutine());
    }

    IEnumerator ShootingCoroutine()
    {
        while (canShoot)
        {
            var bullet = _pool.GetFromPool();
            bullet.gameObject.transform.position = transform.position;
            yield return new WaitForSeconds(shootingDelay);
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}