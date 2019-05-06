using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Grabbable"){
            if(Input.GetButton("Grab")){
                other.transform.position = gameObject.transform.position;
            }
        }
    }


}
