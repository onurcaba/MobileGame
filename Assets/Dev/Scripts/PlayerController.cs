using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float touchSensitivity = 0.2f;

    private Rigidbody rb;
    private Vector2 touchOrigin = -Vector2.one;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 input = GetInput();

        Vector3 movement = new Vector3(input.x, 0f, input.y);
        movement.Normalize();

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }

        rb.velocity = movement * moveSpeed;
    }

    private Vector2 GetInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchOrigin = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended && touchOrigin != -Vector2.one)
            {
                Vector2 touchEnd = touch.position;
                Vector2 input = touchEnd - touchOrigin;
                touchOrigin = -Vector2.one;

                if (input.magnitude < touchSensitivity)
                {
                    input = Vector2.zero;
                }

                return input;
            }
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        return new Vector2(horizontal, vertical);
    }
}