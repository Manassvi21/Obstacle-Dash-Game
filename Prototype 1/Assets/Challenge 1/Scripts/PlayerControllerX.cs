using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float tiltSpeed = 50.0f; // Used to tilt up/down
    public GameObject propeller; // Assign this via inspector

    private float verticalInput;

    void Update()
    {
        // Move the plane forward constantly
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Get input
        verticalInput = Input.GetAxis("Vertical");

        // Tilt the plane up/down only if user presses arrow keys
        transform.Rotate(Vector3.right * verticalInput * tiltSpeed * Time.deltaTime);

        // Make the propeller spin
        if (propeller != null)
        {
            propeller.transform.Rotate(Vector3.forward * 1000 * Time.deltaTime);
        }
    }
}
