using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed = 50.0f;
    public float tiltSpeed = 25.0f;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // Get input from keyboard
        horizontalInput = Input.GetAxis("Horizontal"); // Left/Right
        verticalInput = Input.GetAxis("Vertical");     // Up/Down

        // Move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Tilt up/down based on vertical input
        transform.Rotate(Vector3.right * tiltSpeed * verticalInput * Time.deltaTime);

        // Turn left/right
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
