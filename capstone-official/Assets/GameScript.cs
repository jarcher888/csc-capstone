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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
