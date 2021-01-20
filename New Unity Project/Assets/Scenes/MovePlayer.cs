using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody pl;
    public Transform pla;
    public bool a = false;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Ground")
        {
            a = true;
        }
    }


    void Update()
    {
        if (Input.GetKey("space") && a)
        {
            pl.AddForce(0,300,0);
            a = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pla.transform.position += new Vector3(0, 0, 10*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            pla.transform.position += new Vector3(0, 0, -10*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            pla.transform.position += new Vector3(-10*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            pla.transform.position += new Vector3(10*Time.deltaTime, 0, 0);
        }
    }
    /*private Vector3 GetBaseInput()
    { //returns the basic values, if it's 0 than it's not active.
        if (Input.GetKey(KeyCode.W))
        {
            pla.transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            pla.transform.position += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            pla.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            pla.transform.position += new Vector3(1, 0, 0);
        }
    }*/
}
