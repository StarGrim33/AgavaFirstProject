using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _targetPosition;

    public void StopMoving()
    {
        transform.position = _targetPosition.transform.position;
        _rigidbody.velocity = Vector3.zero;
    }
}
