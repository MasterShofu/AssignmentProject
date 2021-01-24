using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //this is the variable which will control the amount of force
    [SerializeField]
    private float force = 1000f;
    // Start is called before the first frame update
    public GameObject Bullet;
    Vector2 bulletPos;
    public float _fireRate = 0.5f;
    float _nextFire = 0.0f;
    bool facingRight = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        bool pressedJumpButton = Input.GetButtonDown("Jump");

        if (transform.position.y < 0.9) 
        {
        if (pressedJumpButton)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * force);
        }

        if (Input.GetButtonDown ("Fire1") && Time.time > _nextFire)
        {
            _nextFire = Time.time + _fireRate;
            fire ();
        }
        }
    }

    void fire ()
    {
        bulletPos = transform.position;
        if (facingRight)
        {
            bulletPos += new Vector2 (+1.4f, 0.65f);
            Instantiate (Bullet, bulletPos, Quaternion.identity);
        }
    }

}
