using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public CreatureScript player;
    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = Vector3.zero;
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            // forwards
            transform.position += new Vector3(0,0,1);
            //direction.z += 1;
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            // backwards
            transform.position -= new Vector3(0,0,-1);
            //direction.z -= 1;
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            // left
            transform.position -= new Vector3(-1,0,0);
            //direction.x -= 1;
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            // right
                transform.position -= new Vector3(1,0,0);
            //direction.x += 1;
        }
        // if ((direction.x != 0) && (direction.z != 0))
        // {
        //     direction = Vector3.zero;
        // }
        //direction.y = 0;
        //player.Move(direction);
    }
}