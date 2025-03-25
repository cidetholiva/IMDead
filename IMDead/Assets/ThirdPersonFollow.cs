using UnityEngine;

public class ThirdPersonFollow : MonoBehaviour
{
    public Transform target;        // The player
    public Vector3 offset = new Vector3(0, 3, -5); // Camera offset
    public float followSpeed = 5f;
    public float rotationSpeed = 5f;

    void LateUpdate()
    {
        // Follow the target smoothly
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        // Rotate to look at the target
        Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
    }
}
