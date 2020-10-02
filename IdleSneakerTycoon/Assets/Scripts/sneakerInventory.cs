using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakerInventory : MonoBehaviour
{
    public bool nikeMagsbool;
    public bool tomSachsbool;
    public bool travisAJ1bool;
    public bool offWhiteAJ1bool;
    public bool offWhiteAF1bool;
    public bool wotherspoonbool;
    public bool yeezyTurtbool;
    public bool yeezy700bool;
    public GameObject nikeMags;
    public GameObject tomSachs;
    public GameObject travisAJ1;
    public GameObject offWhiteAJ1;
    public GameObject offWhiteAF1;
    public GameObject wotherspoon;
    public GameObject yeezyTurt;
    public GameObject yeezy700;

    public GameObject nikeMagsOG;
    public GameObject tomSachsOG;
    public GameObject travisAJ1OG;
    public GameObject offWhiteAJ1OG;
    public GameObject offWhiteAF1OG;
    public GameObject wotherspoonOG;
    public GameObject yeezyTurtOG;
    public GameObject yeezy700OG;

    // Sneaker Page 2
    public bool chunkyDunkybool;
    public bool diorAJ1bool;
    public bool offWhitePrestobool;
    public bool yeezyQntmbool;
    public bool nikeAirYeezybool;
    public bool nikeSacaibool;
    public bool unionAJ1bool;
    public bool balenciagaSbool;
    public GameObject chunkyDunky;
    public GameObject diorAJ1;
    public GameObject offWhitePresto;
    public GameObject yeezyQntm;
    public GameObject nikeAirYeezy;
    public GameObject nikeSacai;
    public GameObject unionAJ1;
    public GameObject balenciagaS;

    public GameObject chunkyDunkyOG;
    public GameObject diorAJ1OG;
    public GameObject offWhitePrestoOG;
    public GameObject yeezyQntmOG;
    public GameObject nikeAirYeezyOG;
    public GameObject nikeSacaiOG;
    public GameObject unionAJ1OG;
    public GameObject balenciagaSOG;

    //Sneaker Page 3
    public bool halfEvilYellowBool;
    public bool halfEvilPurpleBool;
    public bool offWhiteTeeBool;
    public bool kawsTeeBool;
    public bool antiSocialTeeBool;
    public bool supremeTeeBool;
    public bool bapeTeeBool;
    public bool travisTeeBool;
    public GameObject halfEvilYellow;
    public GameObject halfEvilPurple;
    public GameObject offWhiteTee;
    public GameObject kawsTee;
    public GameObject antiSocialTee;
    public GameObject supremeTee;
    public GameObject bapeTee;
    public GameObject travisTee;

    public GameObject halfEvilYellowOG;
    public GameObject halfEvilPurpleOG;
    public GameObject offWhiteTeeOG;
    public GameObject kawsTeeOG;
    public GameObject antiSocialTeeOG;
    public GameObject supremeTeeOG;
    public GameObject bapeTeeOG;
    public GameObject travisTeeOG;


    // Update is called once per frame
    void Update()
    {
        if (yeezy700bool){
            yeezy700.SetActive(true);
            yeezy700OG.SetActive(false);
        }
        if(yeezyTurtbool){
            yeezyTurt.SetActive(true);
            yeezyTurtOG.SetActive(false);
        }
        if(wotherspoonbool){
            wotherspoon.SetActive(true);
            wotherspoonOG.SetActive(false);
        }
        if (offWhiteAF1bool){
            offWhiteAF1.SetActive(true);
            offWhiteAF1OG.SetActive(false);
        }
        if(travisAJ1bool){
            travisAJ1.SetActive(true);
            travisAJ1OG.SetActive(false);
        }
        if(offWhiteAJ1bool){
            offWhiteAJ1.SetActive(true);
            offWhiteAJ1OG.SetActive(false);
        }
        if(tomSachsbool){
            tomSachs.SetActive(true);
            tomSachsOG.SetActive(false);
        }
        if(nikeMagsbool){
            nikeMags.SetActive(true);
            nikeMagsOG.SetActive(false);
        }
        if(chunkyDunkybool){
            chunkyDunky.SetActive(true);
            chunkyDunkyOG.SetActive(false);
        }
        if(diorAJ1bool){
            diorAJ1.SetActive(true);
            diorAJ1OG.SetActive(false);
        }
        if(offWhitePrestobool){
            offWhitePresto.SetActive(true);
            offWhitePrestoOG.SetActive(false);
        }
        if(yeezyQntmbool){
            yeezyQntm.SetActive(true);
            yeezyQntmOG.SetActive(false);
        }
        if(nikeAirYeezybool){
            nikeAirYeezy.SetActive(true);
            nikeAirYeezyOG.SetActive(false);
        }
        if(nikeSacaibool){
            nikeSacai.SetActive(true);
            nikeSacaiOG.SetActive(false);
        }
        if(unionAJ1bool){
            unionAJ1.SetActive(true);
            unionAJ1OG.SetActive(false);
        }
        if(balenciagaSbool){
            balenciagaS.SetActive(true);
            balenciagaSOG.SetActive(false);
        }
        if(halfEvilYellowBool){
            halfEvilYellow.SetActive(true);
            halfEvilYellowOG.SetActive(false);
        }
        if(halfEvilPurpleBool){
            halfEvilPurple.SetActive(true);
            halfEvilPurpleOG.SetActive(false);
        }
        if(offWhiteTeeBool){
            offWhiteTee.SetActive(true);
            offWhiteTeeOG.SetActive(false);
        }
        if(kawsTeeBool){
            kawsTee.SetActive(true);
            kawsTeeOG.SetActive(false);
        }
        if(antiSocialTeeBool){
            antiSocialTee.SetActive(true);
            antiSocialTeeOG.SetActive(false);
        }
        if(supremeTeeBool){
            supremeTee.SetActive(true);
            supremeTeeOG.SetActive(false);
        }
        if(bapeTeeBool){
            bapeTee.SetActive(true);
            bapeTeeOG.SetActive(false);
        }
        if(travisTeeBool){
            travisTee.SetActive(true);
            travisTeeOG.SetActive(false);
        }
    }
}
