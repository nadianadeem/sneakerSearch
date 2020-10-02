using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMovement : MonoBehaviour
{
    public Vector3 movement;
    // Update is called once per frame
    void Update()
    {
        transform.position += movement * Time.deltaTime;

        if (transform.position.x > 8){
            transform.position = new Vector3 (-2, transform.position.y, 0);
        }

        if(transform.position.x < -3){
            transform.position = new Vector3 (6, transform.position.y, 0);
        }
    }
}
