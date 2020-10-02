using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPlayButton : MonoBehaviour
{
    public GameObject playPrefab;
    // Start is called before the first frame update
    void OnMouseDown(){
        Instantiate(playPrefab, new Vector3(-0.39f, -0.66f, -4.0f), Quaternion.identity);
    }
}
