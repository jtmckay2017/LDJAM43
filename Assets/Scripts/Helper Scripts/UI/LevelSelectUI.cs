using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelSelectUI : MonoBehaviour {


    private TextMeshProUGUI levelText;

    public FloatReference currentSelectedLevel;

    private void Start()
    {
        levelText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        levelText.SetText("LEVEL " + currentSelectedLevel.Value.ToString());
    }
}
