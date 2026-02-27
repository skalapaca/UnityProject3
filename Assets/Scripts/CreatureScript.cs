using UnityEngine;

public class CreatureScript : MonoBehaviour
{
    private bool isKeyCollected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KeyCollected()
    {
        isKeyCollected = true;
    }

    public bool CanOpenDoor()
    {
        if (isKeyCollected)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}