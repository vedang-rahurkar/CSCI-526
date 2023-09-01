using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleObject : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f) * speed * Time.deltaTime;

        if (transform.localScale.x < 0)
            transform.localScale = new Vector3(0f, transform.localScale.y, transform.localScale.z);
        if (transform.localScale.y < 0.1f)
            transform.localScale = new Vector3(transform.localScale.x, 0.1f, transform.localScale.z);
        if (transform.localScale.z < 0)
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 0);
    }
}
