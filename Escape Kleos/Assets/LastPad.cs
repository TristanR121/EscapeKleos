using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPad : MonoBehaviour
{
    public GameObject Door;
    public Vector3 OpenPos;
    public Vector3 ClosedPos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cup2")
        {
            Door.GetComponent<MoveToTarget>().MoveTo(OpenPos);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Door.GetComponent<MoveToTarget>().MoveTo(ClosedPos);
    }
}
