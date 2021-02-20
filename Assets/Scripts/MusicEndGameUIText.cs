using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicEndGameUIText : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scre, combo;
    score  combonum;
    MusicModeScore scorenum;
    public TextMeshProUGUI DisplayText;
    void Start()
    {
        combonum = combo.GetComponent<score>();
        scorenum = scre.GetComponent<MusicModeScore>();
    }

    // Update is called once per frame
    void Update()
    {
        //DisplayText.text = "Game Over\nScore:" + scorenum.currscore.ToString("0") + "\n" + "Highest Combo: " + combonum.highest_score.ToString("0");
        DisplayText.text = "Game Over\nScore:" + MusicModeScore.scoreNum.ToString("0") + "\n" + "Highest Combo: " + MusicModeScore.highest_combo.ToString("0");

    }
}
