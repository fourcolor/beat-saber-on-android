using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreAmount;
    public float currscore = 50;
    public float highest_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }
    public void AddScore(float num)
    {
        currscore += num;
        UpdateScore();
    }
    // Update is called once per frame
    public void UpdateScore()
    {
        scoreAmount.text = currscore.ToString("0");
        if (highest_score < currscore)
        {
            highest_score = currscore;
        }
    }
    public float getnum()
    {
        return currscore;
    }
}
