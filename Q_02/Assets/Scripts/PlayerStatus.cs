using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public float MoveSpeed
    {
        get;
        private set;
    }

    private void Awake()
    {
        Init();     // 초기화 함수 진행
    }

    private void Init()
    {
        MoveSpeed = 5f;     // 이동 속도를 5로 설정
    }
}
