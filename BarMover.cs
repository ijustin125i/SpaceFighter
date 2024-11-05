// Movement of Bar (left to right)
using UnityEngine;

public class BarMover : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed
    public float rightMoveRange = 0.5f; // Distance the bar moves to the right 
    public float leftMoveRange = 1.5f; // Distance the bar moves to the left 
    private float startX; 
    private bool movingRight = true; 

    void Start()
    {
        // Starting x position of var
        startX = transform.position.x;
    }

    void Update()
    {
        float newX = transform.position.x;

        // Move the bar right 
        if (movingRight)
        {
            newX += moveSpeed * Time.deltaTime;

            // Check if the bar has reached the right move limit
            if (newX >= startX + rightMoveRange)
            {
                movingRight = false; // Switch direction to the left
            }
        }
        else
        {
            newX -= moveSpeed * Time.deltaTime;

            // Check if the bar has reached the left move limit
            if (newX <= startX - leftMoveRange)
            {
                movingRight = true; // Switch direction to the right
            }
        }

        // Update the bar's position
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
