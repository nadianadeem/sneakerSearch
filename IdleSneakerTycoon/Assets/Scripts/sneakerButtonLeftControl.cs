using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakerButtonLeftControl : MonoBehaviour
{
    public sneakerControlMaster sneakerControlMaster;

    void OnMouseDown(){
        if(sneakerControlMaster.sneakerPageControl > 1){
            sneakerControlMaster.sneakerPageControl -= 1;
        }
    }
    
}
