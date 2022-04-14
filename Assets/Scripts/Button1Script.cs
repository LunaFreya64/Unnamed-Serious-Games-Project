using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1Script : MonoBehaviour
{
    // Start is called before the first frame update
    private TestScript GameManager;
    public float thisButtonNumber = 1;
    private AudioSource source;
    void Start()
    {
        // Get reference to GameController Script
        GameManager = GameObject.Find("GameController").GetComponent<TestScript>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonclicked()
    {
        // return which button has been clicked

        if (thisButtonNumber == 4)
        {
            GameManager.MoveTimeForward();
            GameManager.RandomizeInClassScenario();
        }else
        {
            GameManager.whichbutton = thisButtonNumber;   
        }
        // GameManager.riskLevel += 50;

        source.Play();
    }
}
