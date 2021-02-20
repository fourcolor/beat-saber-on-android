using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndlessModeLife : MonoBehaviour
{
    public TextMeshProUGUI LifeAmount;
    public int life = 10;

    public AudioClip beat;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        LifeAmount.text = life.ToString();
    }
    public void MinusLife()
    {
        audioSource.PlayOneShot(beat);
        life -= 1;
    }
}
