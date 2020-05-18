using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject blueSpaceship;
    public GameObject orangeSpaceship;
    public GameObject pinkBullet;

    public float spawnDelay;
    public float spawnUpperLimit;
    public float spawnBottomLimit;
    private float spawnTimer = 0f;

    private void Awake()
    {
        spawnTimer = spawnDelay;
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            Spawn();
            spawnTimer = spawnDelay;
        }
    }

    public void Spawn()
    {
        int side = Random.Range(0, 2);
        float spawnX;
        if (side == 0)
        {
            spawnX = -10;
        }
        else
        {
            spawnX = 10;
        }

        float spawnY = Random.Range(spawnBottomLimit, spawnUpperLimit);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);

        int color = Random.Range(0, 2);
        if (color == 0)
        {
            Spaceship spaceship = Instantiate(blueSpaceship, spawnPosition, Quaternion.identity).GetComponent<Spaceship>();
            spaceship.pinkBullet = pinkBullet;
        }
        else
        {
            Spaceship spaceship = Instantiate(orangeSpaceship, spawnPosition, Quaternion.identity).GetComponent<Spaceship>();
            spaceship.pinkBullet = pinkBullet;
        }
    }
}
