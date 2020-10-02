using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniGamePlayerMaster : MonoBehaviour
{
    public sneakerInventory sI;
    public GameObject minimap;
    public minigameMaster minigameMaster;
    public GameObject gamebutton;
    public GameObject shopButton;
    public GameObject infoButton;
    public GameObject upgradeButton;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "enemy"){
            gameObject.SetActive(false);
            Destroy(other);
            minimap.SetActive(false);
            minigameMaster.playing = false;
            minigameMaster.scoreInt = 0;
            gamebutton.SetActive(true);
            shopButton.SetActive(true);
            infoButton.SetActive(true);
            upgradeButton.SetActive(true);
        }
    }

    void Update(){
        if(minigameMaster.scoreInt >= 5000){
            sI.chunkyDunkybool = true;
        }
        if(minigameMaster.scoreInt >= 6000){
            sI.supremeTeeBool = true;
        }
    }
}
