using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal")*speed;
        float v = Input.GetAxis("Vertical")*speed;
        Vector3 dirVector = new Vector3(h,0,v);
        transform.Translate(dirVector);
        transform.TransformDirection(dirVector);
        rigidbody.velocity = dirVector * speed;

    }
}
