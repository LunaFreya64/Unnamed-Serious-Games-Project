using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float welcomebuttonnumber;
    private WelcomeScript WelcomeWindow;
    void Start()
    {
        WelcomeWindow = GameObject.Find("Welcome Window").GetComponent<WelcomeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonclicked()
    {
        if (welcomebuttonnumber == 0)
        {
            if (WelcomeWindow.prevOrNext > 0)
            {
                WelcomeWindow.prevOrNext -= 1;
            }
        } else
        {
            if (WelcomeWindow.prevOrNext < 3)
            {
                WelcomeWindow.prevOrNext +=1;
            }
        }
    }
}
