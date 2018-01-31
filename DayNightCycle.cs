using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour
{

    public float time;
    public float DisplayTime;
    public float intensitySpeed;

    

    public TimeSpan currenttime;
    public Transform SunTransform;
    public Light Sun;

    public Text timeText;
    public Text dayText;
    public Text seasonText;
    public Text yearText;
    public Text ampmText;

    

    public int days, month, year;

    

    public float intensity;
    public Color fogday = Color.grey;
    public Color fognight = Color.black;

    public int speed;

    void Start()
    {
        month = 1;
        days = 1;
        year = 2016;

        // dayText = GameObject.Find("DayText").GetComponent<Text>();

        //yearText = GameObject.Find("YearText").GetComponent<Text>();
        CalculateSeason();

    }

    // Update is called once per frame
    void Update ()
    {
        ChangeTime();

    }


    public void ChangeTime()
    {
        
        time += Time.deltaTime * speed;
        DisplayTime += Time.deltaTime * speed;

        if (time > 86400)
        {
            


            days += 1;
            time = 0;
            TextCallFunction();

            // Calculate Day and Month
            if (days >= 28)
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

        // time display
        //tempTime = time;
        if (DisplayTime > 43200)
        {
            DisplayTime = 0;
            //tempTime += Time.deltaTime * speed;
            ampmText.text = "PM";

        }
        

        currenttime = TimeSpan.FromSeconds(DisplayTime);
        string[] temptime = currenttime.ToString().Split(":"[0]);

        //Text Call function
        timeText.text = temptime[0] + ":" + temptime[1];
        dayText.text = days.ToString();
        yearText.text = year.ToString();

        SunTransform.rotation = Quaternion.Euler(new Vector3((time - 21600) / 86400 * 360, 0, 0));
        
        if (0 < time && time < 21600)
        {
            ampmText.text = "AM";
            intensity = 0.25f;
        }

        if (time < 43200)
        {
            intensity = 1 - (43200 - time) / 43200;
            //intensity = 1 - (43200 - time) / 43200;
            //ampmText.text = "AM";
            if (intensity >= 1)
            {
                intensity = 1;
            }
        }
        // แก้ตรง นี้ด้วย..............................................
        if (57601 < time && time < 86400)
        {
            intensity = 1 - ((intensitySpeed * (Time.deltaTime))/10);
            //intensity = 1 - ((43200 - time) / 43200 * -1);
            if (intensity <= 0.70)
            {
                intensity = 0.70f;
            }
        }

        





        RenderSettings.fogColor = Color.Lerp(fognight, fogday, intensity * intensity);

        Sun.intensity = intensity;





        
    }

    void TextCallFunction()
    {
        dayText.text = days.ToString();
        // clockText.text = "Time: " + hour + ":" + minute;
        yearText.text = "Year: " + year;
    }


    public void CalculateSeason()
    {
        if (month == 1)
            seasonText.text = "Spring";
        else if (month == 2)
            seasonText.text = "Summer";
        else if (month == 3)
            seasonText.text = "Autumn";
        else if (month == 4)
            seasonText.text = "Winter";

    }

    void CalculateMonth()
    {
        if (month == 1 || month == 2 || month == 3 || month == 4)
        {
            if (days >= 31)
            {
                month++;
                days = 1;
                TextCallFunction();
                CalculateSeason();
            }
        }
    }
}
