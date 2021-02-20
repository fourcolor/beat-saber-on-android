using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicModeScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreAmount;
    [SerializeField] TextMeshProUGUI comboAmount;
    static public int scoreNum;
    static public int comboNum;
    static public int highest_combo;
    public float currscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        currscore = 0;
        UpdateScore();

        scoreNum = 0;
        comboNum = 0;
        highest_combo = 0;
    }
    public void AddScore(float num)
    {
        currscore += num;
        UpdateScore();
    }
    // Update is called once per frame
    void UpdateScore()
    {
        scoreAmount.text = scoreNum.ToString();
        comboAmount.text = comboNum.ToString();
        //scoreAmount.text = currscore.ToString("0");
        if (highest_combo < comboNum)
        {
            highest_combo = comboNum;
        }
    }
}
