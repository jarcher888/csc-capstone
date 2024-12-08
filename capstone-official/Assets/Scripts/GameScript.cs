using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{

    public void GoHome(){
        SceneManager.LoadSceneAsync("HomePage");
    }
    public void GoToBigToe(){
        SceneManager.LoadSceneAsync("BigToePlantarFascia");
    }

    public void GoToCalfOnStep(){
        SceneManager.LoadSceneAsync("CalfStretchonStep");
    }

    public void GoToFrozenBottleRoll(){
        SceneManager.LoadSceneAsync("FrozenBottleRoll");
    }
    public void GoToPlantarFasciaStretch(){
        SceneManager.LoadSceneAsync("PlantarFasciaStretch");
    }
    public void GoToStandingStretch(){
        SceneManager.LoadSceneAsync("StandingStretch");
    }
    public void GoToPodiatry(){
        SceneManager.LoadSceneAsync("PodiatryPage");
    }
    public void GoToSpeech(){
        SceneManager.LoadSceneAsync("SpeechPage");
    }
    public void GoToOrtho(){
        SceneManager.LoadSceneAsync("OrthoPage");
    }

    public void GoToWallClimb() {
        SceneManager.LoadSceneAsync("ShoulderWallClimbs");
    }

    public void GoToPecStretch() {
        SceneManager.LoadSceneAsync("PecStretch");
    }

    public void GoToBookStretch() {
        SceneManager.LoadSceneAsync("OpenBookStretch");
    }

    public void GoToCapsuleStretch() {
        SceneManager.LoadSceneAsync("CapsuleStretch");
    }

    public void GoToSleeperStretch() {
        SceneManager.LoadSceneAsync("SleeperShoulderStretch");
    }

    public void GoToFSoundSpeech() {
        SceneManager.LoadSceneAsync("childFSoundSpeech");
    }

    public void GoToSSoundSpeech() {
        SceneManager.LoadSceneAsync("childSSoundSpeech");
    }

    public void GoToShSoundSpeech() {
        SceneManager.LoadSceneAsync("childShSoundSpeech");
    }

    public void GoToRSoundSpeech() {
        SceneManager.LoadSceneAsync("childRSoundSpeech");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
