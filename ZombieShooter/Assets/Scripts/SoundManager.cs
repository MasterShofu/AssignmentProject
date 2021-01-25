using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHit, enemyHit;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerHit = Resources.Load<AudioClip>("Hit");
        enemyHit = Resources.Load<AudioClip>("EnemyDeath");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Hit":
                audioSrc.PlayOneShot (playerHit);
                break;

            case "EnemyDeath":
                audioSrc.PlayOneShot (enemyHit);
                break;
        }
    }
}
