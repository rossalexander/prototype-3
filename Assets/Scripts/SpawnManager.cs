using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25f, 0, 0);
    private float _startDelay = 2f;
    private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacles", _startDelay, _repeatRate);
    }

    private void Update()
    {
    }

    private void SpawnObstacles()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }
}