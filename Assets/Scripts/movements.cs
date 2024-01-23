using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public  float turnSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move the object
        transform.Translate(Vector3.forward * Time.deltaTime *verticalInput);
        //transform.Translate(-Vector3.right * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
    }
}
