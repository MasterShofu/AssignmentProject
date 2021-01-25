using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
    public GameObject ammo;
    float randX;
    
    
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        float _ammospawnRate = Random.Range(1, 60);

        if (Time.time > nextSpawn) 
        {
            nextSpawn = Time.time + _ammospawnRate;
            Instantiate (ammo,new Vector2(transform.position.x,transform.position.y),Quaternion.identity);
        }
    }
}
