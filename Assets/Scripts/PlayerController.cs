using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    private bool _grounded;
    private Animator _playerAnimator;
    [SerializeField] private ParticleSystem impactParticle;
    [SerializeField] private ParticleSystem dirtParticle;

    [SerializeField] private float jumpForce;
    public bool gameOver;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (gameOver) return;
        if (!Input.GetKeyDown(KeyCode.Space) || !_grounded) return;
        _playerAnimator.SetTrigger("Jump_trig");
        _grounded = false;
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        dirtParticle.Stop();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _grounded = true;
            dirtParticle.Play();
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            dirtParticle.Stop();
            impactParticle.Play();
            _playerAnimator.SetBool("Death_b", true);
            _playerAnimator.SetInteger("DeathType_int", 1);
            
            
        }
    }
}