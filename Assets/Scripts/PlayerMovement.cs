using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
  Rigidbody rb;

void Start()
{
    rb = GetComponent<Rigidbody>();
}

void FixedUpdate()
{
    float InputX = Input.GetAxis("Horizontal");
    float InputZ = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(InputX, 0, InputZ) * moveSpeed * Time.fixedDeltaTime;
    rb.MovePosition(rb.position + movement);
}
}
