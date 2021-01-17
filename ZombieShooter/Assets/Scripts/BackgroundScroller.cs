using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BackgroundScroller : MonoBehaviour {

    public float _speed = 3f;
    public bool scroll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if(scroll)
        {
            if(transform.position.x < -17)
            {
                transform.position = new Vector3(18,1,0);
            }
        }
    }
}