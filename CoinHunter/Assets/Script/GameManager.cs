using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.ShaderGraph.Internal;

public class GameManager : MonoBehaviour
{
    public GameObject GameOver;

    public TextMeshProUGUI timeText;

    public TextMeshProUGUI bestRecordText;

    private float surviveTime;
    private bool isGameOver = false;

    private static int score;

    private void Start()
    {
        GameOver.SetActive(false);
    }

    private void Update()
    {
       if(!isGameOver)
        {
            surviveTime += Time.deltaTime;
            timeText.text = $"Time: {Mathf.FloorToInt(surviveTime)}";
        }
       else
        {
            if(Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void EnGame()
    {
        isGameOver = true;
        GameOver.SetActive(true);
        float bestTime = PlayerPrefs.GetFloat("BestTime", 0f);
        if(surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        bestRecordText.text = $"Best Record: {Mathf.FloorToInt(score + bestTime)}";
    }

    public void SetScore()
    {
        score += 10;
    }
}
