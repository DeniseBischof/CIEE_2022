using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Vector3 direction;

    public float speed = 5.0f;

    public Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    public Animator anim;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        direction = new Vector3(horizontal, 0, vertical);

        transform.Translate(direction * speed * Time.deltaTime);

        if (direction != Vector3.zero)
        {
            anim.SetFloat("speed", 1f);
        }
        else
        {
            anim.SetFloat("speed", 0f);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(" You collided.");
    }
}


