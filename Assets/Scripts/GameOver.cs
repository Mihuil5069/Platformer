using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverScreen;
    public bool TimeStop;
    public TextMeshProUGUI LifesCount;
    public int Lifes = 3;
    private AudioSource audioSource;
    public AudioClip DeathSound;
    public AudioClip HitSound;
    // Start is called before the first frame update
    void Start()
    {
        LifesCount.text = "Lifes:" + Lifes.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeStop == true)
        {
            Time.timeScale = 0f;
        }
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            Lifes -= 1;
            LifesCount.text = "Lifes:" + Lifes.ToString();
            audioSource.PlayOneShot(HitSound, 1f);
        }
        else if (collision.gameObject.CompareTag("Spike"))
        {
            Lifes -= 1;
            LifesCount.text = "Lifes:" + Lifes.ToString();
            audioSource.PlayOneShot(HitSound, 1f);
        }
        if (Lifes == 0)
        {
            GameOverScreen.SetActive(true);
            TimeStop = true;
            audioSource.PlayOneShot(DeathSound, 1f);
        }
    }
}
