using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FinishedGameData {
    public bool is_win;
}

public class TimeManager : MonoBehaviour
{
    public int timeLimit = 180;

    private float _startTime = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        var now = Time.time;
        if (now - _startTime > timeLimit)
        {
            // ResultSceneへ（生き残ったので勝ち）
            Debug.Log("Game Finished!");
            FinishedGameData data = new FinishedGameData(){ is_win = true };
            StartCoroutine(SceneTransitioner.Transition("Result Scene", data));
            Destroy(gameObject);
        }
    }

    public int GetCurrentTime()
    {
        var elapsed = Time.time - _startTime;
        return timeLimit - (int)elapsed;
    }
}
