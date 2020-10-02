using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigameMaster : MonoBehaviour
{
    public GameObject miniGame;
    public GameObject mud;
    public GameObject water;

    public GameObject sneaker;
    public Text score;
    public playerController playerController;
    public bool playing;
    public int randomint;
    public int randomTwo;
    public int randomObs;
    public int scoreInt;
    public Vector3 locationOne = new Vector3 (-1.0f, 5, -4);
    public Vector3 locationTwo =  new Vector3(-2.5f, 5, -4);
    public Vector3 locationThree =  new Vector3(0.85f, 5, -4);
    public Vector3 locationFour =  new Vector3(3.56f, 5, -4);

    // Update is called once per frame
    void OnMouseDown()
    {
        if (miniGame.activeSelf == true){
            playing = true;
            gameObject.SetActive(false);
            sneaker.SetActive(true);
        }
    }

    void spawnObs(){
        if(playing == true){
            randomObs = Random.Range(1,4);
            randomint = Random.Range(0,4);
            playerController.cash +=50;
            scoreInt += 50;
            score.text = "CASH EARNED " + scoreInt;
            if(randomObs == 1){
                if(randomint ==1){
                    Instantiate(mud, locationOne, Quaternion.identity);
                }
                if(randomint ==2){
                    Instantiate(mud, locationTwo, Quaternion.identity);
                }
                if(randomint ==3){
                    Instantiate(mud, locationThree, Quaternion.identity);
                }
                if(randomint ==4){
                    Instantiate(mud, locationFour, Quaternion.identity);
                }
            }
            if(randomObs == 2){
                scoreInt += 50;
                if(randomint ==1){
                    Instantiate(water, locationOne, Quaternion.identity);
                }
                if(randomint ==2){
                    Instantiate(water, locationTwo, Quaternion.identity);
                }
                if(randomint ==3){
                    Instantiate(water, locationThree, Quaternion.identity);
                }
                if(randomint ==4){
                    Instantiate(water, locationFour, Quaternion.identity);
                }
            }
            if(randomObs == 3){
                if(randomint ==1){
                    Instantiate(water, locationOne, Quaternion.identity);
                    Instantiate(water, locationTwo, Quaternion.identity);
                }
                if(randomint ==2){
                    Instantiate(mud, locationTwo, Quaternion.identity);
                    Instantiate(mud, locationFour, Quaternion.identity);
                }
                if(randomint ==3){
                    Instantiate(water, locationThree, Quaternion.identity);
                    Instantiate(mud, locationTwo, Quaternion.identity);
                }
                if(randomint ==4){
                    Instantiate(mud, locationFour, Quaternion.identity);
                    Instantiate(mud, locationOne, Quaternion.identity);
                }
            }
        }
    }

    void Start(){
        InvokeRepeating("spawnObs", 0.0f, 2.0f);
    }

}
