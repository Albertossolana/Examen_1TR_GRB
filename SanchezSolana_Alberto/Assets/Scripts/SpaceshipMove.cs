using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovNave();


    }

    void MovNave()
    {
        float MovHorizontal = Input.GetAxis("Horizontal") * speed;
        if (MovHorizontal < -1)
        {
            transform.Translate(Vector3.left * -MovHorizontal * Time.deltaTime);
        }
        if (Input.GetButton("Up"))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
           
        }
        if (Input.GetButton("Down"))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetButton("Delante"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
