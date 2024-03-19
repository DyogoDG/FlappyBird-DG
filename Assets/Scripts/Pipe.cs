using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pipe : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;

        if(transform.position.x < -1.743f)
        {
            //Auto Destruir
            Destroy(gameObject);
        }

    }
}
