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
            case 1:
            welcomePromt.text = "test1";
            break;

            case 2:
            welcomePromt.text = "test2";
            break;

            default:
            welcomePromt.text = "end of text";
            break;
        }
    }
}
