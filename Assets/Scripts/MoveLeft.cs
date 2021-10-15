using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20f;
    private PlayerController _playerController;

    private void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (_playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}