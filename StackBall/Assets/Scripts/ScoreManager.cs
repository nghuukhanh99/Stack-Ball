using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int Score;

    public TextMeshProUGUI ScoreNumber;

    private void Awake()
    {
        Instance = this;
    }
   
    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        
    }

    public void scoreUP()
    {
        Score++;

        ScoreNumber.text = Score.ToString();
    }
}
