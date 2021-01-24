using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour
{
    // Start is called before the first frame update
    public Text finalTime;
    void Start()
    {
        string endScreenText = PlayerPrefs.GetString("finalScore");
        endScreenText.ToString();
        finalTime.text = endScreenText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
