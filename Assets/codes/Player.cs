using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D physic;
    public float speed = 3;
    public float jumpspeed = 300;
    float horizontal = 0f;
    Vector3 vec;
    bool onetimejump = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onetimejump)
            {
                physic.AddForce(new Vector2(0, jumpspeed));
                onetimejump = false;
            }
        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");

        vec = new Vector3(horizontal * speed, physic.velocity.y, 0);

        physic.velocity = vec;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        onetimejump = true;
    }
}
