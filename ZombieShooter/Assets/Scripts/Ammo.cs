using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{  
    public Text ammoAmmount;
    public int currentAmmo;
    private int startAmmo;

    public bool outOfAmmo = false;

    void Start()
    {
        startAmmo = 17;
        currentAmmo = startAmmo;
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetButtonDown("Fire1") && !outOfAmmo && (transform.position.y < 0.24))
        {
            currentAmmo--;
        }

        string viewAmmo = currentAmmo.ToString();
        string viewStartAmmo = startAmmo.ToString();
        ammoAmmount.text = ("Ammo:" + viewAmmo + "/" + viewStartAmmo);

        if(currentAmmo == 0)
        {
            outOfAmmo = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ammo")
        {
            currentAmmo = startAmmo;
            outOfAmmo = false;
            Destroy(other.gameObject);
        }
    }
}
