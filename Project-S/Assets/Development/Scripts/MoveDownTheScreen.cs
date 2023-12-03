using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownTheScreen : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private LayerMask _mask;

    private void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (((1 << other.gameObject.layer) & _mask) != 0)
        {
            Destroy(gameObject); // TODO: Pooling
        }
    }
}
