using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

public class Damageable : MonoBehaviour
{
    [SerializeField] private FloatReference maxHealth;
    [SerializeField] private FloatReference currentHealth;

    [SerializeField] private VoidBaseEventReference damagedEvent;
    [SerializeField] private VoidBaseEventReference dieEvent;

    private void Start()
    {
        currentHealth.Value = maxHealth.Value;
    }

    public void ReceiveDamage(float damage)
    {
        currentHealth.Value -= damage;

        if (currentHealth.Value <= 0)
        {
            Die();
        }
        else
        {
            damagedEvent.Event.Raise();
        }
    }

    private void Die()
    {
        dieEvent.Event.Raise();
    }
}