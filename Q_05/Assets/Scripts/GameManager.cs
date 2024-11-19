using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonBehaviour<GameManager>
{
    public float Score { get; set; }

    private void Awake()
    {
        SingletonInit();
        Score = 0.1f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()        // 일시정지 이후 다시 원래의 시간 속도로 복귀시키기 위한 함수
    {
        Time.timeScale = 1f;
    }

    public void LoadScene(int buildIndex)
    {
        Debug.Log("ddddddddd");
        SceneManager.LoadScene(buildIndex);
    }
}
