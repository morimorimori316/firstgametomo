using System;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision Enter");
        
    }

    void OnCollisionStay(Collision other)
    {
        Debug.Log("Collision Stay");
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Collision Exit");
    }
}
