using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    private Rigidbody CarRb;
    // Start is called before the first frame update
    void Start()
    {
        CarRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(VerticalInput * MovementSpeed * Time.deltaTime, 0, 0);



        if (VerticalInput == 0)
        {

        }
        else
        {
            if (VerticalInput > 0)
            {
                transform.Rotate(0, HorizontalInput * RotationSpeed * Time.deltaTime, 0);
            }
            else
            {
                transform.Rotate(0, HorizontalInput * -RotationSpeed * Time.deltaTime, 0);
            }
        }        
    }
}
