using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakerControlMaster : MonoBehaviour
{
    public int sneakerPageControl = 0;

    public GameObject firstPage;
    public GameObject secondPage;
    public GameObject thirdPage;

    void Update(){
        if(sneakerPageControl == 1){
            firstPage.SetActive(true);
            secondPage.SetActive(false);
            thirdPage.SetActive(false);
        }
        if(sneakerPageControl == 2){
            firstPage.SetActive(false);
            secondPage.SetActive(true);
            thirdPage.SetActive(false);
        }
        if(sneakerPageControl == 3){
            firstPage.SetActive(false);
            secondPage.SetActive(false);
            thirdPage.SetActive(true);
        }
    }
}
