using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public CreatureScript player;
    public LayerMask wallLayer;
    private float tileSize = 100/48f;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            // forwards
            direction = new Vector3(1,0,0);
            TryMove(direction);
        }
        else if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            // backwards
            direction = new Vector3(-1,0,0);
            TryMove(direction);
        }
        else if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            // left
            direction = new Vector3(0,0,1);
            TryMove(direction);
        }
        else if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            // right
            direction = new Vector3(0,0,-1);
            TryMove(direction);
        }
    }

    private void TryMove(Vector3 direction)
    {
        Vector3 targetPostition = player.transform.position + (direction * tileSize);
        if (!Physics.Raycast(player.transform.position, direction, tileSize, wallLayer))
        {
            player.transform.position = targetPostition;
        }
    }
}