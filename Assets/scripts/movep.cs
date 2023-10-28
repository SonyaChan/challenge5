using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movep : MonoBehaviour
{
    bool jump;
    public Vector2 IM;
    public Rigidbody rb;
    public float j = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(IM.x, -0.5f, IM.y);
        rb.velocity = move * 10;
        if (jump)
        {
            rb.AddForce(Vector3.up * 500);
          //rb.AddForce(Vector3.up * j, ForceMode.Impulse);
        }
    }

    public void wasdmove(InputAction.CallbackContext c)
    {
        IM = c.ReadValue<Vector2>();
       
    }

    public void jumping(InputAction.CallbackContext c)
    {
        jump = c.action.triggered;
    }
}
