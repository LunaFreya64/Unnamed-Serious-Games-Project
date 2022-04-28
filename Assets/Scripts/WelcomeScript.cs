using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float prevOrNext = 0;

        void Start()
    {
        TextMesh welcomePromt = GameObject.Find("Welcome Text").GetComponent<TextMesh>();
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh welcomePromt = GameObject.Find("Welcome Text").GetComponent<TextMesh>();

        switch (prevOrNext)
        {
            case 0:
            welcomePromt.text = "You wake up on a bright Monday\nmorning. It is the first day of your\nfreshman year\nat Dwight D. Eisenhower High\nSchool.";
            break;

            case 1:
            welcomePromt.text = "You are a 14 year old transgender\ngirl, assigned male at birth.\nNo one knows, except for one or\ntwo close friends that you trust.\nYou do not want anyone else to\nknow you are transgender yet.\nYou want to ease them into it slowly,\nso as not to freak out or risk your own\nhealth and safety.";
            break;

            case 2:
            welcomePromt.text = "You have to make your way through the\nweek, balancing both your mental health\nand safety. Too much Risk, and you\nmight get found out by your family.\nToo low health levels, and you might\nbecome too overwhelmed and dysphoric\nto continue";
            break;
            
            default:
            welcomePromt.text = "end of text";
            break;
        }
        
    }
}
