using Unity.Mathematics;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject keyVisual;
    public Transform playerHolder;
    private GameObject holdInstance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            holdInstance = Instantiate(keyVisual, playerHolder);
            holdInstance.transform.localPosition = Vector3.zero;
            holdInstance.transform.localRotation = Quaternion.identity;
            Destroy(gameObject);
        }
    }
}