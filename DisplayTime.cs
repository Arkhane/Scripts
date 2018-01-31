using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class DisplayTime : MonoBehaviour {

    //Change this to a const if you don't want to chane the value or a normal int


    private const int TIMESCALE = 45;

    //Setting 
    private Text clockText;
    private Text dayText;
    private Text seasonText;
    private Text yearText;

    private float minute, hour, day, second, month, year;



	// Use this for initialization
	void Start () {
        month = 1;
        day = 1;
        // up to you when you what the year to start
        year = 2016;

        // if you don't do this you will get a null refence exp which can be very annoying.
        clockText = GameObject.Find("___Clock").GetComponent<Text>();
        dayText = GameObject.Find("___Day").GetComponent<Text>();
        seasonText = GameObject.Find("___Season").GetComponent<Text>();
        yearText = GameObject.Find("___Year").GetComponent<Text>();
        CalculateSeason();

    }
	
	// Update is called once per frame
	void Update () {
        CalculateTime();
	}

    void TextCallFunction()
    {
        dayText.text = "Day: " + day;
        clockText.text = "Time: " + hour + ":" + minute;
        yearText.text = "Year: " + year;
    }

    void CalculateSeason()
    {
        if (month == 1 || month == 2 || month == 3)
            seasonText.text = "Spring";
        else if (month == 4 || month == 5 || month == 6)
            seasonText.text = "Summer";
        else if (month == 7 || month == 8 || month == 9)
            seasonText.text = "Autumn";
        else if (month == 10 || month == 11 || month == 12)
            seasonText.text = "Winter";

        // Add a Debug.Log statement here so you con watch the months tick by
        Debug.Log(month + " " + seasonText.text);
    }

    void CalculateMonth()
    {
        if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if(day >= 32)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }

        if (month == 2)
        {
            if (day >= 29)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }

        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 31)
            {
                month++;
                day = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }

    }

    void CalculateTime()
    {
        second += Time.deltaTime * TIMESCALE;

        // If statement are looking for less then or equal to once it hits 60 it will increment minute by 1
        if (second >= 60)
        {
            minute++;
            second = 0;
            TextCallFunction();
        }
        else if (minute >= 60)
        {
            hour++;
            minute = 0;
            TextCallFunction();
        }
        else if (hour >= 24)
        {
            day++;
            hour = 0;
            TextCallFunction();
        }
        else if (day >= 28)
        {
            CalculateMonth();
        }
        else if (month >= 12)
        {
            month = 1;
            year++;
            TextCallFunction();
            CalculateSeason();
        }
    }


}
