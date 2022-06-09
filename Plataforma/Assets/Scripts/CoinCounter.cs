using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {
    static int counter;
    static Text counterText;

    private void Start() {
        counterText = GetComponent<Text>();
        counter = 0;
        counterText.text = "Coins: " + counter;
    }

    public static void SumInt() {
        counter += 1;
        counterText.text = "Coins: " + counter;
    }

    
   

}
