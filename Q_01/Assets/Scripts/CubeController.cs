using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 SetPoint { get; private set; }

    public void SetPosition()
    {
        SetPoint = new Vector3(3, 0, 3);    // SetPoint�� �̵��ϰ��� �ϴ� ��ǥ�� ���ο� Vector3 �� ����
        transform.position = SetPoint;      // SetPoint�� ������Ʈ�� ��ġ�� ����
    }
}
