using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public bool GameStart;
    private string Level;
    private AudioSource audioSource;
    public AudioClip MenuMusic;
    public AudioClip GameMusic;
    public GameObject StartScreen;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.clip = MenuMusic;
        audioSource.Play();
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameStart == true)
        {
            Time.timeScale = 1f;
        }
    }
    public void RestartGame()
    {
        Level = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(Level);
        GameStart = true;
    }
    public void StartGame()
    {
        Debug.Log("start");
        GameStart = true;
        audioSource.Stop();
        audioSource.clip = GameMusic;
        audioSource.Play();
        StartScreen.SetActive(false);
    }
}
