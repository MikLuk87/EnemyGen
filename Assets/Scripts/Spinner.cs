using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private Transform _center;
    [SerializeField] private float _speed = 10f;

    private void Update()
    {
        transform.RotateAround(_center.transform.position, Vector3.up, _speed * Time.deltaTime);
    }
}