using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeDirection());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1, 0, 0);
    }

    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(4f);
    }
}
