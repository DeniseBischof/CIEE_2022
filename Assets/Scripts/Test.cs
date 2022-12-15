using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public bool animation = false;

    public Animator animator_object;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start of the game.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    public void Testtest()
    {
        Debug.Log(animation);
        animator_object.SetBool("anim", true);
    }

    public void setFalse()
    {
        animator_object.SetBool("anim", false);
    }
}
