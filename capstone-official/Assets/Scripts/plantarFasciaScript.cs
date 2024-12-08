using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantarFasciaScript : MonoBehaviour
{
    AudioSource plantarFasciaAudio;

    // Start is called before the first frame update
    void Start()
    {
        plantarFasciaAudio = GetComponent<AudioSource>();
        plantarFasciaAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(plantarFasciaAudio.isPlaying) {
                plantarFasciaAudio.Stop();
                plantarFasciaAudio.Play();
            } else {
                plantarFasciaAudio.Play();
            }
        }
        
    }
}
