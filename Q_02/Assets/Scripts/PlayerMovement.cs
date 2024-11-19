using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerStatus _status;

    private void Awake()
    {
        Init();     // �ʱ�ȭ �Լ� ����
    }

    private void Init()
    {
        _status = GetComponent<PlayerStatus>();     // PlayerStatus ������Ʈ ����
    }

    private void Update()
    {
        MovePosition();     // �̵� �Լ� ����
    }

    // �̵� �Լ�
    private void MovePosition()
    {
        Vector3 direction = Vector3.zero;               // �ʱ� ������ 0���� ����
        direction.x = Input.GetAxisRaw("Horizontal");   // Horizontal(A ,D Ű�� �⺻ �Ҵ�) �Է����� x�� �̵�
        direction.z = Input.GetAxisRaw("Vertical");     // Vertical(W, S Ű�� �⺻ �Ҵ�) �Է����� z�� �̵�

        if (direction == Vector3.zero) return;      // ���� ���� 0�� ��� ���� ó��
        
        // �� �ð����� �̵��ӵ� ��ŭ Ű�� �Է��� �������� �̵�
        // ���� �̵� ��, �밢���� �̵��� ������������ �������� ������ ���� ���� �̵� ������ �Ϲ�ȭ ����
        transform.Translate(_status.MoveSpeed * Time.deltaTime * direction.normalized);
    }
}
