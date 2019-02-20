using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeLeft;
    public Text timeText;
    void Start()
    {
        timeLeft = 60;
        Invoke("UpdateTimeText", 2);
    }

    // Update is called once per frame
    void Update()
    {
        TimerDisplay();
    }
    void TimerDisplay()
    {
        timeLeft -= Time.deltaTime;
        UpdateTimeText();
        print(timeLeft);
        if (timeLeft < 0)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name); ;
        }
    }
    public void UpdateTimeText()
    {
        timeText.text = "Time: " + timeLeft.ToString();
    }

}
