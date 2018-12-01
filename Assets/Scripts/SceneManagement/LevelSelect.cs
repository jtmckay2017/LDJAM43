using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

    public FloatVariable levelIndex;
    public float numberOfLevels = 1;

	public void ChangeLevelUp()
    {
        if (levelIndex.Value == numberOfLevels)
        {
            return;
        }
        levelIndex.ApplyChange(1);
    }

    public void ChangeLevelDown()
    {
        if(levelIndex.Value == 1)
        {
            return;
        }
        levelIndex.ApplyChange(-1);
    }
}
