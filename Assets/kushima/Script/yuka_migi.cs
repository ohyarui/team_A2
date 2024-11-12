using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuka_migi : MonoBehaviour
{

    public GameObject  floor; // 床のゲームオブジェクト
    public Vector3 moveDistance = Vector3.zero; // 移動距離
    public float moveSpeed = 0.0f; // 移動速度

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
            // 床を右に移動
            floor.transform.position = Vector3.MoveTowards(floor.transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // 目標位置に到達したら移動を停止
            if (floor.transform.position == targetPosition)
            {
                isMoving = false;
                moveDistance = -moveDistance;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // "floor"タグのオブジェクトに衝突したら
        {
            // 移動先を計算
            targetPosition += moveDistance;
            isMoving = true; // 移動を開始
        }
    }

}
