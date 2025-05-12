using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelScript : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
// sceneIndex is the number assosciated with each scene
// This function will open that scene
    public void SelectLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
