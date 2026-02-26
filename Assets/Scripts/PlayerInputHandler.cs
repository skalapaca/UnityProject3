using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public CreatureScript player;
    public float tileSize = 100/48f;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            // forwards
            player.transform.position += new Vector3(0,0,1 * tileSize);
        }
        else if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            // backwards
            player.transform.position += new Vector3(0,0,-1 * tileSize);
        }
        else if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            // left
            player.transform.position += new Vector3(-1 * tileSize,0,0);
        }
        else if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            // right
            player.transform.position += new Vector3(1 * tileSize,0,0);
        }
    }
}