using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class miniGamebutton : MonoBehaviour
{
    public GameObject playbutton;

    void OnMouseDown(){
        playbutton.SetActive(true);
    }
}
