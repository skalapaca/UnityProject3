using UnityEngine;

public class CreatureScript : MonoBehaviour
{
    private CharacterController cc;
    public float speed = 10f;
    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 direction)
    {
        if (direction == Vector3.zero)
        {
            return;
        }
        direction = direction.normalized;
        cc.Move(direction);
    }
}