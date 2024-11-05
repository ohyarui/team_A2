using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class player_rotation : MonoBehaviour
{
    private bool player_right = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(player_right)
            {
                Flip();
            }
        }

        else if(Input.GetKeyDown(KeyCode.D))
        {
            if(!player_right)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        //���]�t���O��ύX
        player_right = !player_right;

        //���[�J���X�P�[���𔽓]������
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
