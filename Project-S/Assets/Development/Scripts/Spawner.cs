using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnableObjects;
    [SerializeField] private float _spawnDelay = 2f;
    [SerializeField] private float _collisionCheckRadius = 1f;
    [SerializeField] private Vector2 _spawnAreaSize = new Vector2(5f, 5f);

    [SerializeField] private Color _gizmoColor = Color.red;

    private float _timeSinceLastSpawn;

    private void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;
        if (_timeSinceLastSpawn >= _spawnDelay)
        {
            if (IsSpawnPositionAvailable(out Vector3 spawnPosition))
            {
                SpawnObject(spawnPosition);
                _timeSinceLastSpawn = 0;
            }
        }
    }

    private bool IsSpawnPositionAvailable(out Vector3 spawnPosition)
    {
        spawnPosition = transform.position + new Vector3(
            Random.Range(-_spawnAreaSize.x / 2, _spawnAreaSize.x / 2),
            Random.Range(-_spawnAreaSize.y / 2, _spawnAreaSize.y / 2),
            0);

        Collider[] hitColliders = Physics.OverlapSphere(spawnPosition, _collisionCheckRadius);
        if (hitColliders.Length > 0)
        {
            return false;
        }
        return true;
    }

    private void SpawnObject(Vector3 spawnPosition)
    {
        GameObject toSpawn = ChooseSpawnableObject();
        if (toSpawn != null)
        {
            Instantiate(toSpawn, spawnPosition, Quaternion.identity); // TODO: Pooling
        }
    }

    private GameObject ChooseSpawnableObject()
    {
        float totalChance = 0;
        foreach (var obj in _spawnableObjects)
        {
            if (obj.TryGetComponent<ISpawnable>(out var item))
            {
                totalChance += item.SpawnChance;
            }
        }

        float randomPoint = Random.Range(0, totalChance);
        foreach (var obj in _spawnableObjects)
        {
            if (obj.TryGetComponent<ISpawnable>(out var item))
            {
                if (randomPoint < item.SpawnChance)
                {
                    return obj;
                }
                randomPoint -= item.SpawnChance;
            }
        }

        return null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmoColor;
        Gizmos.DrawWireCube(transform.position, new Vector3(_spawnAreaSize.x, _spawnAreaSize.y, 1));
    }
}
