using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI Score;
    public TextMeshProUGUI LifeAmount;
    public TextMeshProUGUI GameOver;
    public TextMeshProUGUI CountDown;
    public Button RestartButton;

    public static UIManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetCountDown(int number)
    {
        CountDown.text = $" {number}";
    }

    public void UpdateScore(int number)
    {
        Score.text = "Score: " + number;
    }

    public void GameOverPanel(bool condition)
    {
        GameOver.gameObject.SetActive(condition);
        RestartButton.gameObject.SetActive(condition);
    }


}
