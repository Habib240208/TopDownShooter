using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public int zombiesPerWaveMax = 5;
    public int zombiesPerWaveMin = 1;
    public float maxSpeed = 10.0f;
    public float minSpeed = 5.0f;
    public int waveDifficulty = 10;
    public float maxHealth = 200;
    public float minHealth = 20;
    private bool nextWave;
    

    private void Start()
    {
        nextWave = true;
    }

    private void Update()
    {
        if(nextWave && waveDifficulty != 0)
        {
            nextWave = false;
            waveDifficulty--;
            Invoke("SpawnWave", 5f);    
        }
    }

    void SpawnWave()
    {
        for(int i=0; i < Random.Range(zombiesPerWaveMin, zombiesPerWaveMax); i++)
        {
            Vector2 position = RandomCircle(Vector3.zero, 20);
            GameObject clone = Instantiate(zombiePrefab, position, Quaternion.identity);
            clone.GetComponent<Zombie>().speed = Random.Range(minSpeed, maxSpeed);
            clone.GetComponent<HealthManager>().health = Random.Range(minHealth, maxHealth);
        }
        nextWave = true;
    }


    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}