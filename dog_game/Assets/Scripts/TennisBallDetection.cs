using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBallDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tennis Ball")
        {
            Destroy(other.gameObject);
        }

    }
}
