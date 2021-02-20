using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeEndGameUIText : MonoBehaviour
{
    score Score, time, combo;
    // Start is called before the first frame update
    public TextMeshProUGUI DisplayText;
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("score").GetComponent<score>();
        combo = GameObject.FindGameObjectWithTag("combo").GetComponent<score>();
        time = GameObject.FindGameObjectWithTag("time").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayText.text = "Game Over\nScore:" + Score.getnum().ToString("0") + "\n" + "Highest Combo: " + combo.highest_score.ToString("0");
    }
}
