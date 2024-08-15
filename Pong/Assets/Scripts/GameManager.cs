using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    [SerializeField] private GameObject ball;

    [Header("Player1")]
    [SerializeField] private GameObject firstPlayer;
    [SerializeField] private TextMeshProUGUI firstPlayerText;
    [SerializeField] private GameObject firstPlayerGoal;
    private int firstPlayerScore;

    [Header("Player2")]
    [SerializeField] private GameObject secondPlayer;
    [SerializeField] private TextMeshProUGUI secondPlayerText;
    [SerializeField] private GameObject secondPlayerGoal;
    private int secondPlayerScore;
    void Start()
    {
        firstPlayerScore = 0;
        secondPlayerScore = 0;
    }
    public void PlayerOneGoal()
    {
        firstPlayerScore++;
        firstPlayerText.text = firstPlayerScore.ToString();
    }
    public void PlayerTwoGoal()
    {
        secondPlayerScore++;
        secondPlayerText.text = secondPlayerScore.ToString();
    }
    public void Reset()
    {
        firstPlayer.transform.position = firstPlayer.GetComponent<PlayerController>().startPosition;
        secondPlayer.transform.position = secondPlayer.GetComponent<PlayerController>().startPosition;
        ball.transform.position = ball.GetComponent<Ball>().startPosition;
    }
}
