using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigameCloseButton : MonoBehaviour
{
    public minigameMaster minigameMaster;
    // Start is called before the first frame update
    void OnMouseDown(){
        minigameMaster.playing = false;
    }
}
