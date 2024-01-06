using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    const string PLAYER_TAG = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            Collect();
        }
    }

    private void Collect()
    {
        PoolingManager.Instance.GetPool(gameObject).ReturnToPool(this.gameObject);
    }
}
