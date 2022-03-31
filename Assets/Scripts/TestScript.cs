using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update

public float day;
public float mentalHealth;
public float riskLevel = 0;
public float whichbutton = 0;
public float lastButton;

    void Start()
    {
        // Initializing 3D prompt text
        TextMesh promptText = GameObject.Find("Prompt Text").GetComponent<TextMesh>();
        promptText.text = "Test";
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh promptText = GameObject.Find("Prompt Text").GetComponent<TextMesh>();
        switch (day)
        {
            case 1:
                switch (whichbutton)
                {
                    case 1:
                    promptText.text = "you pressed button 1!\nHooray!";
                    break;

                    case 2:
                    promptText.text = "you pressed button 2!\nHooray!";
                    break;

                    case 3:
                    promptText.text = "you pressed button 3!\nHooray!";
                    break;

                    default:
                    promptText.text = "Hello and welcome to the first day!\nthis is not real text";
                    break;
                }
                break;
            default:
                promptText.text = "You somehow reached the end\nof the universe, how did you get\nhere?";
                break;
        }
    }
}
