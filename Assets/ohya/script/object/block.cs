using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    Transform windtrans;
    [SerializeField] private float speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(windtrans != null)
        {
            Vector3  vec = transform.position - windtrans.position;
            vec.Normalize();
            transform.position += vec * Time.deltaTime * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "wind")
        {
            windtrans = collision.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "wind")
        {
            windtrans = null;
        }
    }
}
