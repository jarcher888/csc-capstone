using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public void GoToPodiatry(){
        SceneManager.LoadSceneAsync("PodiatryPage");
    }

    public void GoToSpeech(){
        SceneManager.LoadSceneAsync("SpeechPage");
    }
    public void GoToOrtho(){
        SceneManager.LoadSceneAsync("OrthoPage");
    }

    public void GoHome(){
        SceneManager.LoadSceneAsync("HomePage");
    }

    // public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        
    }
}
