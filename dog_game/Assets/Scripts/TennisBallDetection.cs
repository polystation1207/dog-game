using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TennisBallDetection : MonoBehaviour
{
    [SerializeField] float ballCount;
    [SerializeField] TextMeshProUGUI myText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tennis Ball")
        {
            ballCount += 1;
            myText.text = "tennis balls: " + ballCount;
            Destroy(other.gameObject);
        }

    }
}
