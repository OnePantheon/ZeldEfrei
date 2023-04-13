using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1;
    public float movementThreshold = 0.1f;
    
    
    void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        movement.y = Input.GetAxis("Vertical");
        movement.x = Input.GetAxis("Horizontal");
        if(movement.magnitude < movementThreshold)
            return;
        if (movement.magnitude > 1)
            movement.Normalize();

        float angle = Vector2.SignedAngle(Vector2.up, movement);
        transform.rotation = Quaternion.Euler(0, 0, angle);
        
        // transform.position += (Vector3)movement * (speed * Time.deltaTime);
        rb.MovePosition(rb.position + (movement * (speed * Time.fixedDeltaTime)));
    }
}
