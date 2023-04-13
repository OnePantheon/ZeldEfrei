using UnityEngine;

public class CameraObjectFollewer : MonoBehaviour
{
    public float followDelay = 1;
    public GameObject objectToFollow;
    
    void Update()
    {
        if (objectToFollow == null)
            return;
        
        Vector3 targetPosition = objectToFollow.transform.position;
        targetPosition.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followDelay * Time.deltaTime);
    }
}
