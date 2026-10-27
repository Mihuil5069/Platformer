using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public int Coins;
    public AudioClip CoinSound;
    private AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        Score.text = "Coins:" + Coins.ToString();
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            Coins += 1;
            Score.text = "Coins:" + Coins.ToString();
            AudioSource.PlayOneShot(CoinSound, 1f);
        }
    }
}
