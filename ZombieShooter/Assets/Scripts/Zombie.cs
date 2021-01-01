using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 3f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-_speed * Time.deltaTime,0,0);
        Destroy(gameObject, 7f);
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag.Equals("Player")){
            GameObject.Find("Player").GetComponent<Health>().health -= 1;;
            Destroy(gameObject);
        }

        if (col.gameObject.tag.Equals("Bullet")){
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
