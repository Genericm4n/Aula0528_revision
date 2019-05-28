using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anime;

    private void Start()
    {
    }

    private void Update()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        var vel = 2f;
        var velRot = 200f;

        transform.Translate(Vector3.forward * v * vel * Time.deltaTime);
        transform.Rotate(Vector3.up * h * velRot * Time.deltaTime);

        anime.SetFloat("speed", v);
    }
}