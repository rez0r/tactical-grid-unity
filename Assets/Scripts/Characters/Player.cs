using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	void Update ()
    {
		if(Input.GetKeyUp(KeyCode.A))
        {
            this.TurnLeft();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            this.TurnRight();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            this.MoveForward();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            this.MoveBackward();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(Resources.Load("Bomb"), transform.position + ((transform.up * 0.2f) + (transform.forward * 1)), transform.rotation);
        }

        //Debug.DrawLine(this.gameObject.transform.localPosition, new Vector3(0, 0, 1), Color.red);
    }

    private void MoveForward()
    {
        Vector3 forwardCast = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, forwardCast, 1))
        {
            Debug.Log("Something in front!");
        }
        else
        {
            this.gameObject.transform.Translate(Vector3.forward * 1.0f);
            Debug.Log("Nothing in front!");
        }
    }

    private void MoveBackward()
    {
        Vector3 backwardCast = transform.TransformDirection(Vector3.back);

        if (Physics.Raycast(transform.position, backwardCast, 1))
        {
            Debug.Log("Something in the back!");
        }
        else
        {
            this.gameObject.transform.Translate(Vector3.forward * -1.0f);
            Debug.Log("Nothing in the back!");
        }

    }

    private void TurnLeft()
    {
        this.gameObject.transform.Rotate(0, -90, 0);
    }

    private void TurnRight()
    {
        this.gameObject.transform.Rotate(0, 90, 0);
    }
}
