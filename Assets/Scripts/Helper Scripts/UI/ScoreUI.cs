using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour {

    [Header("UI Text")]
    public GameObject scoreTextGO;
    public GameObject highScoreTextGO;
    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI highScoreText;

    public FloatReference score;
    public FloatReference highScore;

    private void Start()
    {
        scoreText = scoreTextGO.GetComponent<TextMeshProUGUI>();
        highScoreText = highScoreTextGO.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.SetText(score.Value.ToString());
        highScoreText.SetText(highScore.Value.ToString());
    }
}
