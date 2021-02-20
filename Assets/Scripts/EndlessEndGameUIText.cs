using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndlessEndGameUIText : MonoBehaviour
{
    public TextMeshProUGUI DisplayText;
    private EndlessModeSurvivedTime time;
    // Start is called before the first frame update
    void Start()
    {
        time= GameObject.FindGameObjectWithTag("SurvivedTime").GetComponent<EndlessModeSurvivedTime>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayText.text = "Game Over\nSurvived Time:"+time.currstime.ToString("0.00");
    }
}
