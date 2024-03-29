using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int _enemyQuantity;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private Transform _enemy;
    [SerializeField] private List<Transform> _spawnPoints;

    private Vector3 _position;
    private Quaternion _rotation;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_spawnDelay);
        int spawnPointNumber;

        for (int i = 0; i < _enemyQuantity; i++)
        {
            spawnPointNumber = PointSelect();
            _position = _spawnPoints[spawnPointNumber].position;
            _rotation = _spawnPoints[spawnPointNumber].rotation;
            Instantiate(_enemy, _position, _rotation);
            yield return wait;
        }
    }

    private int PointSelect()
    {
        return Random.Range(0, _spawnPoints.Count);
    }
}