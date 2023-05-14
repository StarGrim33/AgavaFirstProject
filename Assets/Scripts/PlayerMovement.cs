using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private KickingBall _kickingBall;

    private float _delay = 1f;
    private bool _canTeleport = false;

    private void OnEnable()
    {
        _kickingBall.OnBallKicked += OnBallKicked;
    }

    private void OnDisable()
    {
        _kickingBall.OnBallKicked -= OnBallKicked;
    }

    private void OnBallKicked()
    {
        _canTeleport = true;
    }

    private void Update()
    {
        StartCoroutine(Teleport());
    }

    private IEnumerator Teleport()
    {
        var waitForSeconds = new WaitForSeconds(_delay);

        if (Input.GetMouseButtonDown(0))
        {
            if (transform.position != _ball.transform.position && Vector3.Distance(transform.position, _ball.transform.position) > 3f)
            {
                transform.position = _ball.transform.position;
                _particleSystem.Play();
                _ball.StopMoving();
            }
        }

        yield return waitForSeconds;
    }
}
