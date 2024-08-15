using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]private bool isPlayerOneGoal;
    [SerializeField]private GameObject gameManagerObject;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayerOneGoal)
            {
                gameManager.PlayerTwoGoal();
            }
            else
            {
                gameManager.PlayerOneGoal();
            }
            gameManager.Reset();
        }
    }
}
