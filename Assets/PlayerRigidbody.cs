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

    void FixedUpdate()
    {
        physics.MovePosition(physics.position + Vector3.right * Time.deltaTime);
    }

    public void Respawn()
    {
        physics.position = position;
        physics.rotation = rotation;
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
