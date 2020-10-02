using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementMinigame : MonoBehaviour
{
    public GameObject sneaker;

    public int movementInt;
    void OnMouseDrag(){
        sneaker.transform.Translate(Vector2.left * movementInt * Time.deltaTime);

        if(sneaker.transform.position.x < 2.0f){
            sneaker.transform.Translate(Vector2.left * -0.5f);
        }
        if(sneaker.transform.position.x > -1.5f){
            sneaker.transform.Translate(Vector2.left * 0.5f);
        }
    }
}
