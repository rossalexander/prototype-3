using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}