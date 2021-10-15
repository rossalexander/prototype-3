using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20f;

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
