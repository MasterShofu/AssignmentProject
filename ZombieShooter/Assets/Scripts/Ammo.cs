using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{  
    public Text ammoAmmount;
    int currentAmmo;
    public int startAmmo;

    void Start()
    {
        startAmmo = 17;
        currentAmmo = startAmmo;
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetButtonDown("Fire1") && currentAmmo > 0)
        {
            currentAmmo--;
        }

        string viewAmmo = currentAmmo.ToString();
        string viewStartAmmo = startAmmo.ToString();
        ammoAmmount.text = ("Ammo:" + viewAmmo + "/" + viewStartAmmo);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ammo")
        {
            currentAmmo = startAmmo;
            Destroy(other.gameObject);
        }
    }
}
