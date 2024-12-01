using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    public Text timerText;
    public Text artifactText;
    private float timer = 300f;  // 5 minutes countdown
    private int score = 0;
    private int artifactsCollected = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            // Game Over condition
            GameOver();
        }
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.FloorToInt(timer).ToString();
    }

    void GameOver()
    {
        // Display game over UI, disable player controls
        Debug.Log("Game Over!");
    }

    public void CollectArtifact(string artifactName)
    {
        artifactsCollected++;
        score += 100; // or based on artifact value
        artifactText.text = "Artifacts: " + artifactsCollected;
        scoreText.text = "Score: " + score;
    }
}
