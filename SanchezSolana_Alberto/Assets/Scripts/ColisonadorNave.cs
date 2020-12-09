using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisonadorNave : MonoBehaviour
{
    [SerializeField] MeshRenderer myMesh;

    void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.name == "Plane")
            {
                //Destroy(gameObject);
                myMesh.enabled = false;
            }
        }  
}

