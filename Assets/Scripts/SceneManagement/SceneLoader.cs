using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SceneLoader : ScriptableObject {
    public List<Scene> scenes;
    public FloatReference sceneID;

    public void LoadSceneID(int sceneNumber){
        SceneManager.LoadScene(sceneNumber);
    }

    public void LoadSceneName(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void LoadCurrentSelectedLevel()
    {
        LoadSceneID((int)sceneID.Value);
    }
}
