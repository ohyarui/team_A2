using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    [SerializeReference] private float moveSpeed = 5f;
    [SerializeReference] private float jumpheight = 300.0f;

    static public bool isGrounded = true;
    Rigidbody2D rbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        //left/right movement
        float moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        // プレイヤーの位置を更新
        transform.Translate(new(moveX, 0));
    }

    void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // 上方向に力を加える事でジャンプする
            rbody2D.AddForce(Vector2.up * jumpheight);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
