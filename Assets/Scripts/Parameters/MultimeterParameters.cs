using UnityEngine;
using UnityEngine.Events;

public abstract class MultimeterParameters : MonoBehaviour
{
    public event UnityAction Passed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out RegulatorTrigger regulatorTrigger))
        {
            Passed?.Invoke();
        }
    }
}
