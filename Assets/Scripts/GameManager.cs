using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI player2ScoreText;
    public int playerScore;
    public int player2Score;
    
    private void Start() 
    {
        playerScoreText.GetComponent<TextMeshProUGUI>();
        player2ScoreText.GetComponent<TextMeshProUGUI>();
        playerScore = 1;
        player2Score = 1;
    }
    public void PlayerAddScore()
    {
        playerScoreText.text = (playerScore++).ToString();
    }
    public void Player2AddScore()
    {
        player2ScoreText.text = (player2Score++).ToString();
    }
}
