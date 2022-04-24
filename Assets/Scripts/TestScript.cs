using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update

public float day;
public float timeOfDay;
public float tempTimeOfDay;
public float mentalHealth;
public float riskLevel = 0;
public float whichbutton = 0;
public float randomInClassScenario;
public bool thirdchoice = true;
public bool timeTransition = false;
public bool inClass;
public bool randomScenarioEvent = false;
public bool setTimeToPresent = false;

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
            //day 1
            case 1:
            switch (timeOfDay)
            {
                case 1:
                switch (whichbutton)
                {
                    case 1:
                    promptText.text = "You build up the courage to wear something that\nfits you a little more comfortably.\nYou already feel better.\nLet's just hope no one stares...";
                    break;

                    case 2:
                    promptText.text = "You slink into some cargo shorts and a\nbutton-up shirt.\nThis is terrible. You feel terrible.\nBut at least it's safe.";
                    break;

                    case 3:
                    promptText.text = "You slide into the ol' reliable hoodie/sweatpants\ncombo.It's not terrible, but you wish it could be a\nlittle better.";
                    break;

                    default:
                    promptText.text = "You get out of bed and stare blankly at your\ncloset.\nWhat are you wearing today?\n\n1.Maybe a little bit feminine...?\n2.Force yourself into masculine-looking clothes.\n3.Inconspicuous hoodie & sweatpants combo.";
                    break;
                }
                break;

                case 2:
                promptText.text = "You arrive at your school. It's a massive,\nintimidating building that you're sure to get lost in.\nStudents are all flooding inside to start the day,\nand you're no different. You slink inside, following\nthe crowd...\n\nPress -> to move on";
                timeTransition = true;
                break;

                case 3:
                switch (whichbutton)
                {
                    case 1:
                    inClass = true;
                    break;

                    case 2:
                    inClass = false;
                    break;

                    default:
                    promptText.text = "Staring at your schedule, you have English first.\n1.Go to class\n2.Skip class";
                    tempTimeOfDay = timeOfDay;
                    timeTransition = true;
                    randomScenarioEvent = true;
                    randomInClassScenario = Random.Range(0,2);
                    break;
                }
                thirdchoice = false;
                break;

                case 4:
                promptText.text = "I did it!!!";
                break;

            default:
            if (inClass == true)
            {
                switch (randomInClassScenario)
                {
                    case 0:
                    switch (whichbutton)
                    {
                        case 1:
                        promptText.text = "You try to correct the teacher on what name to call\nyou. You don't think she heard you,\nbut some other kids might've...";
                        break;

                        case 2:
                        promptText.text = "You grit your teeth and mutter -here-\nimmediately trying to get your mind onto\nsomething else.";
                        break;

                        case 3:
                        promptText.text = "You sit in silence. The teacher repeats your\ndeadname over and over again, before looking at\nyou. -That's you, right? You're [REDACTED]?\nPlease respond when I say your name.";
                        break;

                        default:
                        promptText.text = "Your teacher is taking attendance. They call out\nyour deadname, as expected.\n\n1.Attempt to tell the teacher your preferred name.\n2.Just say -here- and try to brush it off.\n3.Don't say anything.";
                        setTimeToPresent = true;
                        thirdchoice = true;
                        break;
                    }
                    break;

                    case 1:
                    promptText.text = "You overhear two kids sitting behind you whispering to themselves.";
                    break;
                    
                    default:
                    promptText.text = "scenarionotrandomizedcorrectly";
                    break;
                }
            }
            break;
        }
        break;

        default:
            promptText.text = "you somehow got outside time and space";
            break;
        }
    }


    public void MoveTimeForward()
    {
        if (whichbutton == 1 && timeTransition == false && setTimeToPresent == true)
        {
            riskLevel += 25;
            mentalHealth += 25;
            timeOfDay = tempTimeOfDay + 1;
        }else if (whichbutton == 2 && timeTransition == false && setTimeToPresent == true)
        {
            riskLevel -= 25;
            mentalHealth -= 25;
            timeOfDay = tempTimeOfDay + 1;
        }else if (whichbutton == 3 && thirdchoice == true && timeTransition == false && setTimeToPresent == true)
        {
            mentalHealth -= 15;
            timeOfDay = tempTimeOfDay + 1;
        }else if (whichbutton == 1 && timeTransition == false)
        {
            riskLevel += 25;
            mentalHealth += 25;
            timeOfDay += 1;
        }else if (whichbutton == 2 && timeTransition == false)
        {
            riskLevel -=25;
            mentalHealth -= 25;
            timeOfDay += 1;
        }else if (whichbutton == 3 && thirdchoice == true && timeTransition == false)
        {
            mentalHealth -= 15;
            timeOfDay += 1;
        }else if (timeTransition == true && randomScenarioEvent == true)
        {
            timeOfDay = 0;
            timeTransition = false;
        }else if (timeTransition == true)
        {
            timeOfDay +=1;
            timeTransition = false;
        }else if (setTimeToPresent == true)
        {
            timeOfDay = tempTimeOfDay+1;
            setTimeToPresent = false;
        }

        whichbutton = 0;
    }
}
