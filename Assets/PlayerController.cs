using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 200f;
    public Rigidbody2D rb;
    public bool grounded;
    public Transform pisoCheck;
    public float pisoCheckRadius = 0.05f;

    private float xInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        // rb.linearVelocityX = Input.GetAxis("Horizontal") * speed;
        xInput = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocityX = xInput * speed;

        grounded = Physics2D.OverlapCircle(pisoCheck.position, pisoCheckRadius).CompareTag("Piso");
    }

    private void Jump()
    {
        rb.AddForceY(jumpForce, ForceMode2D.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(pisoCheck.position, pisoCheckRadius);
    }
}
