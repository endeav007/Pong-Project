using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text computerScoreText;

    public GameObject MainMenu;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
    }

    
    
  
}
