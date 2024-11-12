using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuka_migi : MonoBehaviour
{

    public GameObject  floor; // ���̃Q�[���I�u�W�F�N�g
    public Vector3 moveDistance = Vector3.zero; // �ړ�����
    public float moveSpeed = 0.0f; // �ړ����x

    private Vector3 targetPosition;
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = floor.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            // �����E�Ɉړ�
            floor.transform.position = Vector3.MoveTowards(floor.transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // �ڕW�ʒu�ɓ��B������ړ����~
            if (floor.transform.position == targetPosition)
            {
                isMoving = false;
                moveDistance = -moveDistance;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // "floor"�^�O�̃I�u�W�F�N�g�ɏՓ˂�����
        {
            // �ړ�����v�Z
            targetPosition += moveDistance;
            isMoving = true; // �ړ����J�n
        }
    }

}
