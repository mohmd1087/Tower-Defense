using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class MoneyUI : MonoBehaviour {

    public TextMeshProUGUI moneyText;

    // Update is called once per frame
    void Update () {
        moneyText.text = "$" + PlayerStats.Money.ToString();
    }
}