using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeClicker : MonoBehaviour
{
    public GameObject button;
    public GameObject upgradeMenu;
    public GameObject shopButton;
    public GameObject otherButton;

    public GameObject upgradeButton;
    // Start is called before the first frame update

    // Update is called once per frame
    void OnMouseDown()
    {
        upgradeMenu.SetActive(true);
        gameObject.SetActive(false);
        button.SetActive(false);
        shopButton.SetActive(false);
        otherButton.SetActive(false);
        upgradeButton.SetActive(false);
    }
}
