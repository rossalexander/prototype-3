using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 _startPos;
    private float _repeatWidth;
    private Renderer _bgRenderer;

    private void Start()
    {
        _bgRenderer = GetComponent<Renderer>();
        _repeatWidth = _bgRenderer.bounds.size.x / 2;
        _startPos = transform.position;
    }

    private void Update()
    {
        if (transform.position.x < _startPos.x - _repeatWidth)
        {
            transform.position = _startPos;
        }
    }
}