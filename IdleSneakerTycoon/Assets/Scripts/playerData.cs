using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData
{
    public int cash;
    public int cashIncrease;
    public int followers;
    public int followerIncrease;

    public int crateProb;
    public int autoCash;

    public int crateCount;
    public int cashCount;
    public int followerCount;
    public int autoCashCount;

    public bool nikeMagsbool;
    public bool tomSachsbool;
    public bool travisAJ1bool;
    public bool offWhiteAJ1bool;
    public bool offWhiteAF1bool;
    public bool wotherspoonbool;
    public bool yeezyTurtbool;
    public bool yeezy700bool;

    public bool chunkyDunkybool;
    public bool diorAJ1bool;
    public bool offWhitePrestobool;
    public bool yeezyQntmbool;
    public bool nikeAirYeezybool;
    public bool nikeSacaibool;
    public bool unionAJ1bool;
    public bool balenciagaSbool;

    public bool halfEvilYellowBool;
    public bool halfEvilPurpleBool;
    public bool offWhiteTeeBool;
    public bool kawsTeeBool;
    public bool antiSocialTeeBool;
    public bool supremeTeeBool;
    public bool bapeTeeBool;
    public bool travisTeeBool;

    public playerData(playerController pC, upgradeMaster crM, upgradeMaster caM, upgradeMaster fM, sneakerInventory sI, upgradeMaster aCM){
        cash = pC.cash;
        cashIncrease = pC.cashIncrease;
        followers = pC.followers;
        followerIncrease = pC.followerIncrease;
        crateProb = pC.crateProb;


        autoCash = pC.autoCash;
        crateCount = crM.count;
        cashCount = caM.count;
        followerCount = fM.count;
        autoCashCount = aCM.count;

        nikeMagsbool = sI.nikeMagsbool;
        tomSachsbool = sI.tomSachsbool;
        offWhiteAF1bool = sI.offWhiteAF1bool;
        offWhiteAJ1bool = sI.offWhiteAJ1bool;
        travisAJ1bool = sI.travisAJ1bool;
        wotherspoonbool = sI.travisAJ1bool;
        yeezy700bool = sI.yeezy700bool;
        yeezyTurtbool = sI.yeezyTurtbool;

        chunkyDunkybool = sI.chunkyDunkybool;
        diorAJ1bool = sI.diorAJ1bool;
        offWhitePrestobool = sI.offWhitePrestobool;
        yeezyQntmbool = sI.yeezyQntmbool;
        nikeAirYeezybool = sI.nikeAirYeezybool;
        nikeSacaibool = sI.nikeSacaibool;
        unionAJ1bool = sI.unionAJ1bool;
        balenciagaSbool = sI.balenciagaSbool;

        halfEvilYellowBool = sI.halfEvilYellowBool;
        halfEvilPurpleBool = sI.halfEvilPurpleBool;
        offWhiteTeeBool = sI.offWhiteTeeBool;
        kawsTeeBool = sI.kawsTeeBool;
        antiSocialTeeBool = sI.antiSocialTeeBool;
        bapeTeeBool = sI.bapeTeeBool;
        supremeTeeBool = sI.supremeTeeBool;
        travisTeeBool = sI.travisTeeBool;
    }
}
