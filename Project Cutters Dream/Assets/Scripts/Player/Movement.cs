using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hor;
    public float ver;
    public float moveSp;
    public Vector3 moveDir;
    void Start()
    {
        moveSp = 2;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        moveDir.x = hor;
        moveDir.z = ver;

        transform.Translate(moveDir * moveSp * Time.deltaTime);
    }
}
