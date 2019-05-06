using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    void Update(){
        if(Input.GetButton("Grab")){
            print("clicky");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Grabbable"){
            print("I can grab this.");
        }
    }
}
