using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovmentPlayer : MonoBehaviour
{
    public string Horizontal;
    public string Vertical;
    public Rigidbody rb;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rb.velocity = movement * 5;

    }

   
}
