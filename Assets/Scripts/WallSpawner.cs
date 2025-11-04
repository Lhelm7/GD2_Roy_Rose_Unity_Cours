using System;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _wallPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    private int _spawnPointIndex = 0;
    private void OnEnable()
    {
        PlayerCollect.OnTargetCollected += SpawnNewWall;
    } 
    private void OnDisable()
    {
        PlayerCollect.OnTargetCollected -= SpawnNewWall;
    }

    private void SpawnNewWall(int score)
    {
        if (_spawnPointIndex >= _spawnPoints.Length)
        {
            return;
        }
        Instantiate(_wallPrefab, _spawnPoints[_spawnPointIndex].position, _spawnPoints [_spawnPointIndex].rotation);
        _spawnPointIndex++;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
