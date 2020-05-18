using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalLimit;
    public float shotDelay;

    private void Update()
    {
        // Move Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move(-movementSpeed * Time.deltaTime);
        }
        // Move Right
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Move(movementSpeed * Time.deltaTime);
        }
    }

    private void Move(float movement)
    {
        transform.Translate(new Vector2(movement, 0));
        if (transform.position.x < -horizontalLimit)
        {
            transform.position = new Vector2(-horizontalLimit, transform.position.y);
        }
        else if (transform.position.x > horizontalLimit)
        {
            transform.position = new Vector2(horizontalLimit, transform.position.y);
        }
    }
}
