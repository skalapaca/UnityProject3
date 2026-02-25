using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public Transform followTransform;
    // camera follows player
    void LateUpdate()
    {
        transform.position = followTransform.position;
    }
}