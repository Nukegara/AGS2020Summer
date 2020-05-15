using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
	[SerializeField] Text timerText;

	[SerializeField] float totalTime;
	int seconds;

	public static bool gameoverFlag;

	// Use this for initialization
	void Start()
	{
		gameoverFlag = false;
	}

	// Update is called once per frame
	void Update()
	{
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		timerText.text = "残り時間 : " + seconds.ToString() + "秒";
		if(seconds == 0)
		{
			gameoverFlag = true;
			totalTime = 0;
		}
	}
}
