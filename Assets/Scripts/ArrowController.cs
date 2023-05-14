using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public Transform target;
    public float arrowSpeed = 1.0f;

    private Transform arrowTransform;

    void Start()
    {
        arrowTransform = transform;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 targetPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            target.position = targetPos;
        }

        Vector3 direction = (target.position - arrowTransform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        arrowTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        arrowTransform.localScale = new Vector3(Vector3.Distance(target.position, arrowTransform.position), 1, 1);
    }
}
