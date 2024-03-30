using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;

    private Transform _target = EnemySpawner.Target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}