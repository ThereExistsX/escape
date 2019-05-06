using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Hand : MonoBehaviour {
    public XRNode NodeType;

    void Update(){
        transform.localPosition = InputTracking.GetLocalPosition(NodeType);
        transform.localRotation = InputTracking.GetLocalRotation(NodeType);
    }

    void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Grabbable"){
            if(Input.GetButton("Grab")){
                print(InputTracking.GetLocalPosition(NodeType));
                other.transform.position = gameObject.transform.position;
            }
        }
    }
}
