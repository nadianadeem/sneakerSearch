using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public GameObject cashPrefab;
    private int time = 2;
    public upgradeMaster crM;
    public upgradeMaster caM;
    public upgradeMaster fM;
    public upgradeMaster aCM;
    public GameObject cratePrefab;
    public sneakerInventory sI;
    public Text cashText;

    public Text followerText;

    public int cash;
    public int cashIncrease = 10;
    public int autoCash = 200;

    public int followers;

    public int followerIncrease = 2;

    public int crateProb = 1;

    public Vector3 locationOne = new Vector3 (-1.0f, 5, -1);
    public Vector3 locationTwo = new Vector3 (-2.0f, 5, -1);
    public Vector3 locationThree = new Vector3 (0f, 5, -1);
    public Vector3 locationFour = new Vector3 (1.0f, 5, -1);
    public Vector3 locationFive = new Vector3 (2.0f, 5, -1);
    public int randInt;

    public void loadGame(){
        playerData pData = saveSystem.LoadPlayer();
        cash = pData.cash;
        followers = pData.followers;
        cashIncrease = pData.cashIncrease;
        followerIncrease = pData.followerIncrease;
        crateProb = pData.crateProb;
        autoCash = pData.autoCash;

        crM.count = pData.crateCount;
        caM.count = pData.cashCount;
        fM.count = pData.followerCount;
        aCM.count = pData.autoCashCount;

        sI.nikeMagsbool = pData.nikeMagsbool;
        sI.tomSachsbool = pData.tomSachsbool;
        sI.wotherspoonbool = pData.wotherspoonbool;
        sI.offWhiteAF1bool = pData.offWhiteAF1bool;
        sI.offWhiteAJ1bool = pData.offWhiteAJ1bool;
        sI.travisAJ1bool = pData.travisAJ1bool;
        sI.yeezy700bool = pData.yeezy700bool;
        sI.yeezyTurtbool = pData.yeezyTurtbool;

        sI.chunkyDunkybool = pData.chunkyDunkybool;
        sI.diorAJ1bool = pData.diorAJ1bool;
        sI.offWhitePrestobool = pData.offWhitePrestobool;
        sI.yeezyQntmbool = pData.yeezyQntmbool;
        sI.nikeAirYeezybool = pData.nikeAirYeezybool;
        sI.nikeSacaibool = pData.nikeSacaibool;
        sI.unionAJ1bool = pData.unionAJ1bool;
        sI.balenciagaSbool = pData.balenciagaSbool;

        sI.halfEvilYellowBool = pData.halfEvilYellowBool;
        sI.halfEvilPurpleBool = pData.halfEvilPurpleBool;
        sI.offWhiteTeeBool = pData.offWhiteTeeBool;
        sI.kawsTeeBool = pData.kawsTeeBool;
        sI.bapeTeeBool = pData.bapeTeeBool;
        sI.antiSocialTeeBool = pData.antiSocialTeeBool;
        sI.supremeTeeBool = pData.supremeTeeBool;
        sI.travisTeeBool = pData.travisTeeBool;
    }

    // Start is called before the first frame update
    void Start()
    {
        loadGame();
    }

    void Update(){
        cashText.text = "" + cash;
        followerText.text = "" + followers;
        saveGame();

        if(time < Time.time){
            time += 7;
            followers = followers + followerIncrease;
            cash = cash + autoCash;
            crateDropper();
            Debug.Log(autoCash);
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        followerText.text = "" + followers;
        cashText.text = "" + cash;

        if (Input.touchCount > 0) {
            if (Input.GetTouch(0).phase == TouchPhase.Began){
                cash = cash + cashIncrease;
                cashText.text = "" + cash;
                randInt = Random.Range(1,6);
                if(randInt == 1){
                    Instantiate(cashPrefab, locationOne, Quaternion.identity);
                }
                if(randInt == 2){
                    Instantiate(cashPrefab, locationTwo, Quaternion.identity);
                }
                if(randInt == 3){
                    Instantiate(cashPrefab, locationThree, Quaternion.identity);
                }
                if(randInt == 4){
                    Instantiate(cashPrefab, locationFour, Quaternion.identity);
                }
                if(randInt == 5){
                    Instantiate(cashPrefab, locationFive, Quaternion.identity);
                }
            }
        }

        if (followers > 20000000){
            sI.diorAJ1bool = true;
        }

        if (followers > 40000000){
            sI.travisTeeBool = true;
        }

        if (followers > 2000000){
            sI.tomSachsbool = true;
        }

        if (followers > 5000000){
            sI.nikeMagsbool = true;
        }
    }

    void crateDropper(){
        if (crateProb > Random.Range(0, 20)){
            Instantiate(cratePrefab, new Vector3(0.97f, 4.05f, 0.0f), Quaternion.identity);
        }
    }

    public void saveGame(){
        saveSystem.SavePlayer(this, crM, caM, fM, sI, aCM);
    }
}
