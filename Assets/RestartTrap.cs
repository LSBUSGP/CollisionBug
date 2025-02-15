using UnityEngine;

public class RestartTrap : MonoBehaviour
{
    Vector3 position;
    Quaternion rotation;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        position = transform.position;
        rotation = transform.rotation;
    }

    public void Restart()
    {
        rb.isKinematic = true;
        rb.position = position;
        rb.rotation = rotation;
    }

    public void Drop()
    {
        rb.isKinematic = false;
    }
}
