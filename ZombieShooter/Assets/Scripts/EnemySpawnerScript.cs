using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject zombie;
    float randX;
    
    
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        float _spawnRate = Random.Range(1, 5);

        if (Time.time > nextSpawn) 
        {
            nextSpawn = Time.time + _spawnRate;
            Instantiate (zombie,new Vector2(transform.position.x,transform.position.y),Quaternion.identity);
        }
    }
}
