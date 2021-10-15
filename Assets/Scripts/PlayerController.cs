using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    private bool _grounded;
    [SerializeField] private float jumpForce;
    public bool gameOver;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (!Input.GetKeyDown(KeyCode.Space) || !_grounded) return;
        _grounded = false;
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _grounded = true;
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}