using UnityEngine;
using UnityAtoms.BaseAtoms;

public class Damageable : MonoBehaviour
{
    [SerializeField] private FloatConstant maxHealth;
    [SerializeField] private FloatVariable currentHealth;

    [SerializeField] private VoidEvent damagedEvent;
    [SerializeField] private VoidEvent dieEvent;

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
            damagedEvent.Raise();
        }
    }

    private void Die()
    {
        dieEvent.Raise();
    }
}