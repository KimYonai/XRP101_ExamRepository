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
        CreateCube();           // ť�� ������ ���� �Լ�
        SetCubePosition();      // ť�� ������ ��ġ ���� �Լ�
    }

    // ť�� ������ ��ġ ���� �Լ�
    private void SetCubePosition()
    {
        _cubeController = _cubePrefab.GetComponent<CubeController>();   // ť�� �������� CubeController ������Ʈ ����
        _cubeSetPoint = _cubeController.SetPoint;                       // CubeController�� SetPoint�� ť�� ������ ��ġ�� ����
        _cubeController.SetPosition();                                  // CubeController�� SetPosition �Լ� ����
    }

    // ť�� ������ ���� �Լ�
    private void CreateCube()
    {
        GameObject cube = Instantiate(_cubePrefab);     // ť�� ������ ����
    }
}
