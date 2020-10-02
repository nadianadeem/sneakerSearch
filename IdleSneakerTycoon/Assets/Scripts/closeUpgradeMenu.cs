using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUpgradeMenu : MonoBehaviour
{
    public GameObject button;

    public GameObject secondButton;
    public GameObject thirdButton;
    public GameObject upgradeMenu;
    public GameObject otherButton;

    // Update is called once per frame
    void OnMouseDown()
    {
        upgradeMenu.SetActive(false);
        button.SetActive(true);
        secondButton.SetActive(true);
        thirdButton.SetActive(true);
        otherButton.SetActive(true);
    }
}
