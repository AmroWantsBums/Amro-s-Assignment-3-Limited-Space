using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMovement : MonoBehaviour
{
    public float MovementSpeed;
    public bool Forward = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeDirection());
    }

    // Update is called once per frame
    void Update()
    {        
        if (Forward)
        {
            transform.Translate(1 * MovementSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-1 * MovementSpeed * Time.deltaTime, 0, 0);
        }
    }

    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(4f);
        if (Forward)
        {
            transform.Rotate(0, 180, 0); 
            Forward = false;
            StartCoroutine(ChangeDirection());
        }
        else
        {
            transform.Rotate(0, 0, 0);
            Forward = true;
            StartCoroutine(ChangeDirection());
        }
    }
}
