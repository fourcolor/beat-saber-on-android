using System;
using UnityEngine;
using TMPro;

public class EndlessModeSurvivedTime : MonoBehaviour
{
    public TextMeshProUGUI STimeAmount;
    public float currstime = 0;
    private EndlessModeLife life;
    // Start is called before the first frame update
    void Start()
    {
        life = GameObject.FindGameObjectWithTag("Life").GetComponent<EndlessModeLife>();
       if (STimeAmount!=null)
        STimeAmount.text = currstime.ToString("0.00");
    }
    //Update is called once per frame
    private void Update()
    {
        if (life.life > 0)
            currstime += Time.deltaTime;
       if (STimeAmount != null)
            STimeAmount.text = currstime.ToString("0.00");
    }
}
