using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroycomponent : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space));
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}     

