using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    public float rotateSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        // player sprite follows player mover
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        // player sprite turns in the direction player mover goes
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;
        // stay looking in the same direction even if player sprite is on mover
        if (direction == Vector3.zero)
        {
            return;
        }
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
    }
}