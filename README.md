# Collision Bug

This project demonstrates a bug in Unity physics when using the `CharacterController` component on the player. It contains 3 scenes:
- ResetTrapRigidbody
- ResetTrapCharacterController
- ResetTrapCharacterControllerWorkaround

## Expected behaviour

In the `ResetTrapRigidbody` scene, the expected behaviour is demonstrated. The player object moves into the trigger, the trigger releases the trap, the trap hits the player, the player and trap reset, and the routine repeats.

## Unexpected behaviour

In the `ResetTrapCharacterController` scene, the player object is implemented with a `CharacterController` instead of a `Rigidbody`. In this version, the routine plays out as above for the first iteration, but on the second time the trap hits the player, the hit is not detected.

## Workaround

In `ResetTrapCharacterControllerWorkaround` a script with an empty function is added to the trap.

```cs
using UnityEngine;

public class RestartTrapWorkaround : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
    }
}
```

This makes it work.
