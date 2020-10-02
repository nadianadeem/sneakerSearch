using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakerPageControl : MonoBehaviour
{
    public GameObject sneakerPage;
    public GameObject nextSneakerPage;
    public GameObject nextButton;
    // Start is called before the first frame update
    void OnMouseDown(){
        nextSneakerPage.SetActive(true);
        sneakerPage.SetActive(false);
        nextButton.SetActive(true);
        
    }
}
