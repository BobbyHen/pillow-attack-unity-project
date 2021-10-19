using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnKey : MonoBehaviour
{
    public float RotSpeed;
    ///a field, type the degrees per frame to rotate will arrows held
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fire bullet
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GetComponent<ConstantForce>().enabled = true;
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            transform.Rotate(Vector3.down * Time.deltaTime *RotSpeed);
        }

        if (Input.GetAxis("Horizontal") > 0f)
        {
            transform.Rotate(Vector3.up*Time.deltaTime* RotSpeed);
        }
    }
}
