using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherMouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Vector2 sens;
    private Vector2 rotation;
    
     private Vector2 GetInput()
    {
      Vector2 input = new Vector2(
    0,
    Input.GetAxis("Mouse Y")
            );
        return input;
       }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 wantedVelocity = GetInput() * sens;
            rotation += wantedVelocity * Time.deltaTime;
            rotation.y = Mathf.Clamp(rotation.y, -60, 60);
            transform.localEulerAngles = new Vector3(-rotation.y, 0, 0);
        }

    }
    

}
