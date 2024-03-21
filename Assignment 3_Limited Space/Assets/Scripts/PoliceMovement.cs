using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float TurnTime;
    private bool TimeToTurn = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeDirection());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * MovementSpeed * Time.deltaTime, 0, 0);
        if (TimeToTurn)
        {
            transform.Rotate(0, 180, 0);
            TimeToTurn = false;
        }
    }

    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(TurnTime);
        Debug.Log("Its time");
        TimeToTurn = true;
        StartCoroutine(ChangeDirection());
    }
}
