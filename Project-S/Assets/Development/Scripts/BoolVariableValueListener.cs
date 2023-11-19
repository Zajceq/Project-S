using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityEngine.Events;
using System.Collections;

public class BoolVariableValueListener : MonoBehaviour
{
    [SerializeField] private BoolVariable boolVariable;
    [SerializeField] private UnityEvent onTrue;
    [SerializeField] private UnityEvent onFalse;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f);
        TriggerEventBasedOnValue(boolVariable.Value);
    }

    private void OnEnable()
    {
        boolVariable.Changed.Register(OnValueChanged);
    }

    private void OnDisable()
    {
        boolVariable.Changed.Unregister(OnValueChanged);
    }

    private void OnValueChanged(bool value)
    {
        TriggerEventBasedOnValue(value);
    }

    private void TriggerEventBasedOnValue(bool value)
    {
        if (value)
        {
            onTrue.Invoke();
        }
        else
        {
            onFalse.Invoke();
        }
    }
}