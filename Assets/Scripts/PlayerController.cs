using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float planeSpeed = 20.0f;
    private float rotationSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * planeSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left, planeSpeed * Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInput);
    }
}
