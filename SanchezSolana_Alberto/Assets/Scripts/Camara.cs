using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] Transform Objetivo;
    [SerializeField] Transform InitPos;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Objetivo.position.y + 100, transform.position.z);
        transform.LookAt(Objetivo);
    }
}
