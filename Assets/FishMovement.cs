using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    Vector3 targetPosition = Vector3.zero;

    private void Update()
    {
        if (targetPosition == Vector3.zero)
        {
            targetPosition = Random.insideUnitSphere * 2.0f;
            targetPosition.z = 0;
        }
        else
        {
            var direction = targetPosition - transform.position;
            transform.position += direction.normalized * Time.deltaTime;
        }

        if (Vector3.Distance(transform.position, targetPosition) < 0.05f)
        {
            targetPosition = Vector3.zero;
        }


    }
}
