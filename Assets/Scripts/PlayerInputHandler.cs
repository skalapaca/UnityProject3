using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public CreatureScript player;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            // forwards
            direction.z -= 1;
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            // backwards
            direction.z += 1;
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            // left
            direction.x += 1;

        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            // right
            direction.x -= 1;
        }
        direction.y = 0;
        player.Move(direction);
    }
}