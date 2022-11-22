using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    [SerializeField] AudioSource WinAudio;
    [SerializeField] AudioSource LooseAudio;
    [SerializeField] Text resultText;
    void Start()
    {
        if(BossController.wonFlag==1)
        { 
            resultText.text = "You Won!! ";
            WinAudio.Play();
            BossController.wonFlag = 0;
        }
        else
        {
            LooseAudio.Play();
        }
    }
    
    public void StartGame()
    {
        BossController.a = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}