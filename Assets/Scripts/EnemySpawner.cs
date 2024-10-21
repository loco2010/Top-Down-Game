using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnGap;
    private float lastSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastSpawnTime + spawnGap){
            spawnEnemy();
            lastSpawnTime = Time.time;
        }
    }

    void spawnEnemy(){
        int facing = Random.Range(0, 361);
        Instantiate(enemy, transform.position, Quaternion.Euler(0, 0, facing));
    }
}
