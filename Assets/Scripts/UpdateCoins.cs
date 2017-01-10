using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCoins : MonoBehaviour {

    // Use this for initialization
    // Use this for initialization
    public static int money;
    public static int maxMoney;
    public Text TXT;
    Text txt;
    void Start()
    {
        money = 0;
        txt = TXT.GetComponent<Text>();
        txt.text = "Coins: " + money + "/" + maxMoney;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Coins: " + money + "/" + maxMoney;
    }
}
