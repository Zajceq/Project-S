using System.Collections;
using UnityEngine;
using UnityAtoms.MyAtoms;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private float shootingDelay;

    private PoolPrefab _pool;
    private Coroutine _shootingCoroutine;

    private void Start()
    {
        _pool = PoolingManager.Instance.CreatePool(projectile.projectileData.Value.ProjectilePrefab.gameObject, 5);
    }

    public void StartShooting()
    {
        if (_shootingCoroutine == null)
        {
            _shootingCoroutine = StartCoroutine(ShootingCoroutine());
        }
    }

    public void StopShooting()
    {
        if (_shootingCoroutine != null)
        {
            StopCoroutine(_shootingCoroutine);
            _shootingCoroutine = null;
        }
    }

    IEnumerator ShootingCoroutine()
    {
        while (true)
        {
            var bullet = _pool.GetFromPool();
            bullet.transform.position = transform.position;
            yield return new WaitForSeconds(shootingDelay);
        }
    }

    private void OnDisable()
    {
        StopShooting();
    }
}