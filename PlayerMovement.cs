
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Toc do di chuyen cua nhan vat
    [SerializeField] private float moveSpeed = 5f;

    // Bien luu Rigidbody
    private Rigidbody rb;

    // Huong di chuyen
    private Vector3 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movement = new Vector3(horizontal, 0f, vertical).normalized;
    }

    private void FixedUpdate()
    {
        Vector3 nextPosition = rb.position
            + movement * moveSpeed * Time.fixedDeltaTime;

        rb.MovePosition(nextPosition);
    }
}
