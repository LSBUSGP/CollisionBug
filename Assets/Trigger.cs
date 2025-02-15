using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent triggerTrap;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerTrap.Invoke();
        }
    }
}
