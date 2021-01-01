using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;

    public bool isDead;

    void Update() {
        if (numOfHearts > health)
        {
            numOfHearts = health;
        }

        for (int i = 0; i < hearts.Length; i++) 
        {
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }

        if(health == 0)
        {
            isDead = true;
        }
    }

}
