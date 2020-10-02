using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakerbuttonRightControl : MonoBehaviour
{
    public sneakerControlMaster sneakerControlMaster;

    void OnMouseDown(){
        if(sneakerControlMaster.sneakerPageControl < 3){
            sneakerControlMaster.sneakerPageControl += 1;
        }
    }
}
