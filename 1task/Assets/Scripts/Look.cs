using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector2 sens;
    private Vector2 rotation;
    [SerializeField] private Camera camera;
   
    private Vector2 GetInput()
    {
        Vector2 input = new Vector2(
      Input.GetAxis("Mouse X"),
     0
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

            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out RaycastHit raycastHit);

            Vector3 lol = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);
            //transform.LookAt(lol);
            Vector3 dir = lol - transform.position;
            Quaternion rot = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.Lerp(transform.rotation, rot, 4 * Time.deltaTime);
           
        }

    }

}
