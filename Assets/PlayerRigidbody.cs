using UnityEngine;

public class PlayerRigidbody : MonoBehaviour
{
    Vector3 position;
    Quaternion rotation;
    Rigidbody physics;

    void Awake()
    {
        Application.targetFrameRate = 60;
        position = transform.position;
        rotation = transform.rotation;
        physics = GetComponent<Rigidbody>();
    }

    void Update()
    {
        physics.velocity = Vector3.right;
    }

    public void Respawn()
    {
        physics.isKinematic = true;
        physics.position = position;
        physics.rotation = rotation;
        physics.isKinematic = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        RestartTrap restartTrap = collision.gameObject.GetComponent<RestartTrap>();
        if (restartTrap != null)
        {
            Respawn();
            restartTrap.Restart();
        }
    }
}
