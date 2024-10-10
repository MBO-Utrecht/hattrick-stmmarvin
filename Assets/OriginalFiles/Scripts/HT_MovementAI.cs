using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HT_MovementAI : MonoBehaviour
{
    public float speed = 2.0f;
    public float amplitude = 5.0f;
    private float startX;

    void Start()
    {
        // Store the initial x position
        startX = transform.position.x;
    }

    void Update()
    {
        // Calculate the new x position using a sine wave for smooth oscillation
        float newX = startX + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BowlingBall"))
        {
            // Logic to catch the bowling ball
            Debug.Log("Caught the bowling ball!");
            // Implement catching logic here
        }
        else if (other.gameObject.CompareTag("Bomb"))
        {
            // Logic to move aside when recognizing a bomb
            Debug.Log("Recognized a bomb! Moving aside.");
            MoveAside();
        }
    }

    void MoveAside()
    {
        // Move the hat aside (e.g., to the right)
        transform.position += Vector3.right * amplitude;
    }
}
