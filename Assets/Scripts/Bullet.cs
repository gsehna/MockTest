using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Spaceship.Color color;
    public float speed;

    private void Update()
    {
        transform.Translate(new Vector2(0, speed * Time.deltaTime));
        if (transform.position.y > 6 || transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
