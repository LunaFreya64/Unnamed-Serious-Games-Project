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
public float randomOutClassScenario;
public bool thirdchoice = true;
public bool timeTransition = false;
public bool inClass;
public bool randomScenarioEvent = false;
public bool setTimeToPresent = false;
public bool moveForwardDay = false;
public bool ifHighRisk = false;
public GameObject thirdButton;

    void Start()
    {
        // Initializing 3D prompt text
        TextMesh promptText = GameObject.Find("Prompt Text").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh promptText = GameObject.Find("Prompt Text").GetComponent<TextMesh>();
        TextMesh stressText = GameObject.Find("Stress Counter").GetComponent<TextMesh>();

        stressText.text = "Mental Health: " + mentalHealth + "%";

        if (riskLevel >= 50)
        {
            ifHighRisk = true;
        }else
        {
            ifHighRisk = false;
        }

        switch (day)
        {
            //day 1
            case 1:
            switch (timeOfDay)
            {
                case 1:
                //do first period prompt
                switch (whichbutton)
                {
                    case 1:
                    promptText.text = "You build up the courage to wear something that\nfits you a little more comfortably.\nYou already feel better.\nLet's just hope no one stares...\n\n+mental health\n+risk";
                    break;

                    case 2:
                    promptText.text = "You slink into some cargo shorts and a\nbutton-up shirt.\nThis is terrible. You feel terrible.\nBut at least it's safe.\n\n-mental health\n-risk";
                    break;

                    case 3:
                    promptText.text = "You slide into the ol' reliable hoodie/sweatpants\ncombo.It's not terrible, but you wish it could be a\nlittle better.\n\n-mental health";
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
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    case 2:
                    inClass = false;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    default:
                    promptText.text = "Staring at your schedule, you have English first.\n1.Go to class\n2.Skip class";
                    tempTimeOfDay = timeOfDay;
                    timeTransition = true;
                    randomScenarioEvent = true;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;
                }
                thirdButton.SetActive(false);
                thirdchoice = false;
                break;

                case 4:
                switch (whichbutton)
                {
                    case 1:
                    inClass = true;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    case 2:
                    inClass = false;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    default:
                    promptText.text = "Next period is your American History class.\n1.Go to class\n2.Skip class";
                    tempTimeOfDay = timeOfDay;
                    timeTransition = true;
                    randomScenarioEvent = true;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    thirdchoice = false;
                    break;
                }
                break;

                case 5:
                promptText.text = "After Math class is your lunch period.\nYou enter the cafeteria with your food in hand.\nYou see your friends sitting off in the corner.\n\nPress -> to move on";
                timeTransition = true;
                break;

                case 6:
                switch (whichbutton)
                {
                    case 1:
                    inClass = true;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    case 2:
                    inClass = false;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    default:
                    promptText.text = "Next period is your Biology class.\n1.Go to class\n2.Skip class";
                    tempTimeOfDay = timeOfDay;
                    timeTransition = true;
                    randomScenarioEvent = true;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    thirdchoice = false;
                    break;
                }
                break;

                case 7:
                switch (whichbutton)
                {
                    case 1:
                    inClass = true;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    case 2:
                    inClass = false;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    break;

                    default:
                    promptText.text = "Last period of the day is Gym class.\n1.Go to class\n2.Skip class";
                    tempTimeOfDay = timeOfDay;
                    timeTransition = true;
                    randomScenarioEvent = true;
                    randomInClassScenario = Random.Range(0,2);
                    randomOutClassScenario = Random.Range(0,2);
                    thirdchoice = false;
                    break;
                }
                break;

                case 8:
                promptText.text = "You have reached the end of day 1!\nPress -> to see results";
                setTimeToPresent = false;
                moveForwardDay = true;
                break;

            default:
            if (inClass == true && ifHighRisk == false)
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
                        thirdButton.SetActive(true);
                        thirdchoice = true;
                        break;
                    }
                    break;

                    case 1:
                    promptText.text = "You overhear two kids sitting behind you\nwhispering to themselves.";
                    setTimeToPresent = true;
                    break;
                    
                    default:
                    promptText.text = "scenarionotrandomizedcorrectly";
                    break;
                }
            }else if (inClass == false && ifHighRisk == false)
            {
                switch (randomOutClassScenario)
                {
                    case 0:
                    switch (whichbutton)
                    {
                        case 1:
                        promptText.text = "She's surprisingly unphased, and tells you where\nshe got it from! You spend a little bit of time\ntalking about fashion.";
                        break;

                        case 2:
                        promptText.text = "You keep your head down and walk past her.\n-As if I could ever pull that off- you think.";
                        break;

                        case 3:
                        promptText.text = "You keep walking, but stare at the dress for\na better look. The girl is visibly weirded out by\nyour insistent staring.";
                        break;

                        default:
                        promptText.text = "You see a girl in the hallway passing by you.\nShe's wearing a really pretty dress with floral\nstitchings on it, which immediately catches your\nattention.\n1.Stare at the dress\n2.Ask about the dress\n3.Ignore her and keep walking";
                        setTimeToPresent = true;
                        thirdButton.SetActive(true);
                        thirdchoice = true;
                        break;
                    }
                    break;

                    case 1:
                    switch (whichbutton)
                    {
                        case 1:
                        promptText.text = "-Oh...I...um...ah...hi.- you acted very awkward.";
                        break;

                        case 2:
                        promptText.text = "-I'm sorry. I have to go now.\nMy family is calling me.-";
                        break;

                        case 3:
                        promptText.text = "You run away";
                        break;

                        default:
                        promptText.text = "You meet someone at school that you think is\nattractive.\n1.Introduce yourself\n2.Make an excuse\n3.Run Away";
                        setTimeToPresent = true;
                        thirdButton.SetActive(true);
                        thirdchoice = true;
                        break;
                    }
                    break;

                    default:
                    promptText.text = "2scenarionotrandomizedcorrectly";
                    break;
                }
            }else if (inClass == true && ifHighRisk == true)
            {
                switch (randomInClassScenario)
                {
                    case 0:
                    switch (whichbutton)
                    {
                        case 1:
                        promptText.text = "You raise your hand, telling the teacher";
                        break;

                        case 2:
                        promptText.text = "You slightly turn your head around to see two\nboys, laughing at you with crumpled up paper in\ntheir hands. The teachers notices all of you, and\nassumes you're passing notes.";
                        break;

                        case 3:
                        promptText.text = "You try to shut it all out, but another piece\nof paper hits you. This continues for another 5\nminutes, until the teacher finally notices and tells\nthem to stop.";
                        break;

                        default:
                        promptText.text = "You're trying to focus on the\nlesson at hand when suddenly, you feel a small\nball of paper hit the back of your head, followed\nby snickering coming from the back of the room.\n\n1.Tell the teacher\n2.Turn your head around and look\n3.Ignore it";
                        setTimeToPresent = true;
                        thirdButton.SetActive(true);
                        thirdchoice = true;
                        break;
                    }
                    break;

                    case 1:
                    switch (whichbutton)
                    {
                        case 1:
                        promptText.text = "decision 1";
                        break;

                        case 2:
                        promptText.text = "decision 2";
                        break;

                        case 3:
                        promptText.text = "decision 3";
                        break;

                        default:
                        promptText.text = "highriskinclass2";
                        setTimeToPresent = true;
                        thirdButton.SetActive(true);
                        thirdchoice = true;
                        break;
                    }
                    break;
                }
                break;
            }else if (inClass == false && ifHighRisk == true)
            {
                switch (randomOutClassScenario)
                {
                    case 0:
                    switch (whichbutton)
                    {
                        case 1:
                        promptText.text = "decision 1";
                        break;

                        case 2:
                        promptText.text = "decision 2";
                        break;

                        case 3:
                        promptText.text = "decision 3";
                        break;

                        default:
                        promptText.text = "highriskoutclass1";
                        setTimeToPresent = true;
                        thirdButton.SetActive(true);
                        thirdchoice = true;
                        break;
                    }
                    break;

                    case 1:
                    switch (whichbutton)
                    {
                        case 1:
                        promptText.text = "decision 1";
                        break;

                        case 2:
                        promptText.text = "decision 2";
                        break;

                        case 3:
                        promptText.text = "decision 3";
                        break;

                        default:
                        promptText.text = "highriskoutclass2";
                        setTimeToPresent = true;
                        thirdButton.SetActive(true);
                        thirdchoice = true;
                        break;
                    }
                    break;
                }
                break;
            }
            break;
        }
        break;

        default:
        promptText.text = "You have reached the end of day 1\nand also the end of the game as of now!";
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
            randomScenarioEvent = false;
        }else if (timeTransition == true)
        {
            timeOfDay +=1;
            timeTransition = false;
        }else if (setTimeToPresent == true)
        {
            timeOfDay = tempTimeOfDay+1;
            setTimeToPresent = false;
        }else if (moveForwardDay == true)
        {
            day += 1;
            moveForwardDay = false;
        }

        whichbutton = 0;
    }
}
