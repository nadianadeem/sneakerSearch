using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradeMaster : MonoBehaviour
{
    public Slider costSlider;

    public Text costText;

    public playerController pC;

    public int[] costs = new int[] {500, 1000, 10000, 50000, 150000, 300000, 600000, 1200000, 0};

    public int[] autoCashCosts = new int[] {1000000, 5000000, 10000000, 20000000, 4000000, 60000000, 80000000, 10000000, 0};
    public int[] sliderVals = new int[] {10, 22, 31, 41, 51, 61, 71, 81, 91, 100};

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        costSlider.value = 0;
        costSlider.maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        costSlider.value = sliderVals[count];
        costText.text = costs[count].ToString();
        if (costSlider.value == 100){
            Destroy(gameObject);
        }
        if(gameObject.tag == "autoCash"){
            costText.text = autoCashCosts[count].ToString();
        }
        if(count == 9){
            Destroy(costText);
        }
    }
    
    void OnMouseDown(){
        if (pC.cash >= costs[count]){
            if(gameObject.tag == "cashUpgrade"){
                pC.cashIncrease += pC.cashIncrease;
                pC.cash = pC.cash - costs[count];
                costSlider.value = sliderVals[count];
                count += 1;
            }
            if(gameObject.tag == "followerUpgrade"){
                pC.followerIncrease = pC.followerIncrease + pC.followerIncrease;
                pC.cash = pC.cash - costs[count];
                costSlider.value = sliderVals[count];
                count += 1;
            }
            if(gameObject.tag == "crateUpgrade"){
                pC.crateProb += 1;
                pC.cash = pC.cash - costs[count];
                costSlider.value = sliderVals[count];
                count += 1;
            }

        }
        if(pC.cash >= autoCashCosts[count]){
            if(gameObject.tag == "autoCash"){
                if(pC.autoCash == 0){
                    pC.autoCash = 200;
                }
                pC.autoCash = pC.autoCash + pC.autoCash;
                pC.cash = pC.cash - autoCashCosts[count];
                costSlider.value = sliderVals[count];
                count += 1;
            }
        }
    }
}
