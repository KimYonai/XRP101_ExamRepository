using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    private CubeController _cubeController;
    private Vector3 _cubeSetPoint;

    private void Start()
    {
        CreateCube();           // 큐브 프리팹 생성 함수
        SetCubePosition();      // 큐브 프리팹 위치 설정 함수
    }

    // 큐브 프리팹 위치 설정 함수
    private void SetCubePosition()
    {
        _cubeController = _cubePrefab.GetComponent<CubeController>();   // 큐브 프리팹의 CubeController 컴포넌트 참조
        _cubeSetPoint = _cubeController.SetPoint;                       // CubeController의 SetPoint를 큐브 프리팹 위치로 설정
        _cubeController.SetPosition();                                  // CubeController의 SetPosition 함수 실행
    }

    // 큐브 프리팹 생성 함수
    private void CreateCube()
    {
        GameObject cube = Instantiate(_cubePrefab);     // 큐브 프리팹 생성
    }
}
