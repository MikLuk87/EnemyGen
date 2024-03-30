using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int _enemyQuantity;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private List<Transform> _enemys;
    [SerializeField] private List<Transform> _targets;

    public static Transform Target;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_spawnDelay);
        int index;

        for (int i = 0; i < _enemyQuantity; i++)
        {
            index = GetRandomIndex();
            Target = _targets[index];
            Instantiate(_enemys[index]);
            yield return wait;
        }
    }

    private int GetRandomIndex()
    {
        return Random.Range(0, _enemys.Count);
    }
}