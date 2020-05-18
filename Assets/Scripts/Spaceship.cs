using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public enum Color
    {
        Pink,
        Blue,
        Orange
    }

    public bool isPlayer;
    public Color color;
    public float movementSpeed;
    public float horizontalLimit;
    public float shotDelay;
    private float shotTimer = 0f;

    public GameObject blueBullet;
    public GameObject orangeBullet;
    public GameObject pinkBullet;

    private void Update()
    {
        if (isPlayer)
        {
            PlayerAction();
        }
        else
        {
            EnemyAction();
        }
    }

    private void PlayerAction()
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

        if (shotTimer == 0f)
        {
            // Blue Bullet
            if (Input.GetKey(KeyCode.Z))
            {
                Instantiate(blueBullet, transform.position, Quaternion.identity).name = "Blue Bullet";
                shotTimer = shotDelay;
            }
            // Orange Bullet
            else if (Input.GetKey(KeyCode.X))
            {
                Instantiate(orangeBullet, transform.position, Quaternion.identity).name = "Orange Bullet";
                shotTimer = shotDelay;
            }
        }
        else
        {
            shotTimer -= Time.deltaTime;
            if (shotTimer < 0f)
            {
                shotTimer = 0f;
            }
        }
    }

    private void EnemyAction()
    {
        transform.Translate(new Vector2(movementSpeed * Time.deltaTime, 0));
        if (transform.position.x > 11 ||
            transform.position.x < -11)
        {
            Die();
        }

        shotTimer += Time.deltaTime;
        if (shotTimer >= shotDelay)
        {
            Instantiate(pinkBullet, transform.position, Quaternion.identity);
            shotTimer = 0f;
        }
    }

    public void Move(float movement)
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

    public void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Collided");
            Bullet bullet = collision.GetComponent<Bullet>();
            if (color == bullet.color)
            {
                Die();
            }
        }
    }
}
