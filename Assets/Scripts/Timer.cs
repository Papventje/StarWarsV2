using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [SerializeField]
    private Text timerText;
    private float timer;

	// Use this for initialization
	void Start () {
        timer = 4f;
	}
	
    void TimerTextUI()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);

        string totalTime = string.Format("{0:00}:{1:0}", minutes, seconds);

        timerText.text = totalTime;
    }

	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        TimerTextUI();
	}
}
