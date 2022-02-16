using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    public static GUIManager Instance;

    public Button SettingButton;

    public Button MusicButton;

    public Button MuteButton;

    public Button RestartButton;

    public Button PauseButton;

    public Button PlayButton;

    public Button TapToNextLv;

    public Button TapToPlay;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SettingClick()
    {
        if(PlayerCtrl.Instance.isGameActive == true)
        {
            MusicButton.gameObject.SetActive(true);

            MuteButton.gameObject.SetActive(true);

            RestartButton.gameObject.SetActive(true);
        }
        

    }

    public void PauseClick()
    {
        if(PlayerCtrl.Instance.isGameActive == true)
        {
            PauseButton.gameObject.SetActive(false);

            PlayButton.gameObject.SetActive(true);

            Time.timeScale = 0;
        }
        
    }

    public void PlayClick()
    {
        if (PlayerCtrl.Instance.isGameActive == true)
        {
            PlayButton.gameObject.SetActive(false);

            PauseButton.gameObject.SetActive(true);

            Time.timeScale = 1;
        }
         
    }

    public void RestartClick()
    {
        SceneManager.LoadScene(0);
    }

    public void TapNextLvClick()
    {
        SceneManager.LoadScene("Lv2");

        Time.timeScale = 1;

        Debug.Log("Go to Lv2");
    }

    public void TapToPlayGame()
    {
        PlayerCtrl.Instance.isGameActive = true;

        TapToPlay.gameObject.SetActive(false);
    }

    public void TapToMute()
    {
        SoundManager.Instance.audioSource.mute = !SoundManager.Instance.audioSource.mute;
    }

    public void TapToUnMute()
    {
        SoundManager.Instance.audioSource.mute = !SoundManager.Instance.audioSource.mute;
    }
}
