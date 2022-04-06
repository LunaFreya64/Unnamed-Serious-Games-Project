using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update

public float day;
public float timeOfDay;
public float mentalHealth;
public float riskLevel = 0;
public float whichbutton = 0;
public float lastButton;

    void Start()
    {
        // Initializing 3D prompt text
        TextMesh promptText = GameObject.Find("Prompt Text").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh promptText = GameObject.Find("Prompt Text").GetComponent<TextMesh>();

        switch (day)
        {
            case 1:
            switch (timeOfDay)
            {
                case 1:
                switch (whichbutton)
                {
                    case 1:
                    promptText.text = "You are a 14 year old transgender\ngirl, assigned male at birth.\nNo one knows, except for one or\ntwo close friends that you trust.\nYou do not want anyone else to know you are transgender yet.\nYou want to ease them into it slowly,\nso as not to freak out or risk your own health and safety.";
                    break;

                    case 2:
                    promptText.text = "you pressed button 2!\nHooray!";
                    break;

                    case 3:
                    promptText.text = "you pressed button 3!\nHooray!";
                    break;

                    default:
                    promptText.text = "You wake up on a bright Monday\nmorning. It is the first day of your\nfreshman year\nat Dwight D. Eisenhower High\nSchool. ";
                    break;
                }
                break;

                default:
                promptText.text = "This text means that the time of day does not exist";
                break;
            }
                break;
            default:
                promptText.text = "You somehow broke time and space";
                break;
        }
    }

    IEnumerator MoveTimeForward()
    {
        yield return new WaitForSeconds(5);
        timeOfDay += 1;
    }

    IEnumerator StartSequence()
    {
        TextMesh promptText = GameObject.Find("Prompt Text").GetComponent<TextMesh>();
        yield return new WaitForSeconds(5);
        promptText.text = "You are a 14 year old transgender girl, assigned male at birth. No one knows, except for one or two close friends that you trust. You don’t want anyone else to know you are transgender yet. You want to ease them into it slowly, so as not to freak out or risk your own health and safety.";
        Debug.Log("it should end here");
    }
}
