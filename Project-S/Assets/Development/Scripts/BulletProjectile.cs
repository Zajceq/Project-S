using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MyAtoms;
using UnityEditor;

public class BulletProjectile : Projectile
{
    [SerializeField] private float shootingDelay;
    [SerializeField] private float shootingDistance;

    [SerializeField] private bool canShoot;

    private PrefabPool _pool;

    private void Start()
    {
        _pool = PoolingManager.Instance.CreatePool(projectileData.projectilePrefab.gameObject, 50);
        Debug.Log(_pool.ToString());

        StartCoroutine(ShootingCoroutine());
    }

    IEnumerator ShootingCoroutine()
    {
        while(canShoot)
        {
            var bullet = _pool.GetFromPool();
            bullet.gameObject.transform.position = transform.position;
            isActive = true;
            yield return new WaitForSeconds(shootingDelay);
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
