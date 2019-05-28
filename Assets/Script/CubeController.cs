using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject objectLookAt;

    private void Start()
    {
    }

    private void Update()
    {
        transform.LookAt(objectLookAt.transform);

        var velT = 2f;

        var direction = (objectLookAt.transform.position - transform.position).normalized;

        transform.Translate(Vector3.forward * velT * Time.deltaTime);
    }
}