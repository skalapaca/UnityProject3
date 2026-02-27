using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public KeyPickup keyPickup;
    public GameObject unlockedDoorPrefab;
    private GameObject doorInstance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UnlockDoor()
    {
        Destroy(gameObject);
        doorInstance = Instantiate(unlockedDoorPrefab, transform.position, transform.rotation);
        keyPickup.RemoveKeyVisual();
    }
}