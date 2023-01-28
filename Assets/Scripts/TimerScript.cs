using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private float startTime = 0;
    public Text textbox;
    private bool completedMaze = false;



    // Start is called before the first frame update
    void Start()
    {
        textbox.text = startTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!completedMaze)
        {
            startTime += Time.deltaTime;
            textbox.text = "FIND THE YELLOW BALL: " + Mathf.Round(startTime).ToString();
        }

    }

    public void StopTimer()
    {
        completedMaze = true;
    }
}
