using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    Vector3 position;
    Quaternion rotation;
    CharacterController characterController;

    void Awake()
    {
        Application.targetFrameRate = 60;
        position = transform.position;
        rotation = transform.rotation;
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        characterController.Move(Vector3.right * Time.deltaTime);
    }

    public void Respawn()
    {
        characterController.enabled = false;
        transform.position = position;
        transform.rotation = rotation;
        characterController.enabled = true;
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
