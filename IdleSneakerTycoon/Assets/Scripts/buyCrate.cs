using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyCrate : MonoBehaviour
{
    public GameObject cashNotif;

    public GameObject followerNotif;

    public GameObject sneakerNotif;
    public GameObject deadNotif;

    public playerController pC;
    public sneakerInventory sI;

    private int upgradeChoice;
    private int listNum;

    private int shoeProb;
    public int[] prizes = new int[] {10, 50, 100, 5000, 2500, 15000, 20000, 10000, 1000, 75};

    // Start is called before the first frame update
    void OnMouseDown(){
        if (pC.cash >= 10000){
            pC.cash -= 10000;
            pC = GameObject.FindWithTag("Player").GetComponent<playerController>();
        sI = GameObject.FindWithTag("Player").GetComponent<sneakerInventory>();
        shoeProb = Random.Range(1,601);
        upgradeChoice = Random.Range(1,5);
        listNum = Random.Range(0,10);
        if (upgradeChoice == 1){
            Instantiate(cashNotif, new Vector3(-0.03f, 1.76f, 0.0f), Quaternion.identity);
            pC.cash += prizes[listNum];
        }
        else if (upgradeChoice == 2){
            Instantiate(followerNotif, new Vector3(-0.03f, 1.76f, 0.0f), Quaternion.identity);
            pC.followers += prizes[listNum];
        }
        else if (upgradeChoice == 3){
            if(shoeProb == 1){
                if (sI.yeezy700bool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.yeezy700bool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 2){
                if (sI.yeezyTurtbool == false){ 
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.yeezyTurtbool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 3){
                if (sI.wotherspoonbool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.wotherspoonbool = true;
                }
                else {
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 4){
                if(sI.travisAJ1bool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.travisAJ1bool = true;
                }
                else {
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 5){
                if(sI.offWhiteAJ1bool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.offWhiteAJ1bool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 6){
                if(sI.offWhiteAF1bool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.offWhiteAF1bool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 7){
                if(sI.yeezyQntmbool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.yeezyQntmbool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 8){
                if(sI.nikeAirYeezybool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.nikeAirYeezybool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 9){
                if(sI.nikeSacaibool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.nikeSacaibool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 10){
                if(sI.offWhitePrestobool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.offWhitePrestobool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 11){
                if(sI.balenciagaSbool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.balenciagaSbool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 12){
                if(sI.unionAJ1bool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.unionAJ1bool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 13){
                if(sI.halfEvilYellowBool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.halfEvilYellowBool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 14){
                if(sI.halfEvilPurpleBool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.halfEvilPurpleBool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 15){
                if(sI.kawsTeeBool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.kawsTeeBool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }if(shoeProb == 16){
                if(sI.antiSocialTeeBool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.antiSocialTeeBool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 17){
                if(sI.bapeTeeBool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.bapeTeeBool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb == 18){
                if(sI.offWhiteTeeBool == false){
                    Instantiate(sneakerNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                    sI.offWhiteTeeBool = true;
                }
                else{
                    Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
                }
            }
            if(shoeProb >=19){
                Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, -1.0f), Quaternion.identity);
            }
            
        }
        else if (upgradeChoice > 3){
            Instantiate(deadNotif, new Vector3(-0.03f, 1.76f, 0.0f), Quaternion.identity);
        }
    }
   }
}
