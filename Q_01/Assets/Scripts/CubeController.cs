using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 SetPoint { get; private set; }

    public void SetPosition()
    {
        SetPoint = new Vector3(3, 0, 3);    // SetPoint에 이동하고자 하는 좌표로 새로운 Vector3 값 대입
        transform.position = SetPoint;      // SetPoint를 오브젝트의 위치로 설정
    }
}
