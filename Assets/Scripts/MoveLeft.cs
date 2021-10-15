using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 20f;

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
