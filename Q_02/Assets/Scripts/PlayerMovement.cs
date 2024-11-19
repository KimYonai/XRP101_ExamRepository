using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerStatus _status;

    private void Awake()
    {
        Init();     // 초기화 함수 진행
    }

    private void Init()
    {
        _status = GetComponent<PlayerStatus>();     // PlayerStatus 컴포넌트 참조
    }

    private void Update()
    {
        MovePosition();     // 이동 함수 실행
    }

    // 이동 함수
    private void MovePosition()
    {
        Vector3 direction = Vector3.zero;               // 초기 방향을 0으로 설정
        direction.x = Input.GetAxisRaw("Horizontal");   // Horizontal(A ,D 키로 기본 할당) 입력으로 x축 이동
        direction.z = Input.GetAxisRaw("Vertical");     // Vertical(W, S 키로 기본 할당) 입력으로 z축 이동

        if (direction == Vector3.zero) return;      // 방향 값이 0일 경우 예외 처리
        
        // 매 시간마다 이동속도 만큼 키를 입력한 방향으로 이동
        // 방향 이동 시, 대각선의 이동이 비정상적으로 빨라지는 문제를 막기 위해 이동 방향의 일반화 진행
        transform.Translate(_status.MoveSpeed * Time.deltaTime * direction.normalized);
    }
}
