using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour
{
    AudioSource audioSource;
    VideoPlayer videoPlayer;
    [SerializeField] string videoFileName;
    float tick = 4.0f;
    bool videoStarted;
    // Start is called before the first frame update
    void Start()
    {
        LoadVideo();
        videoPlayer.time = 0;
        videoPlayer.Pause();
        PlayAudio();
    }

    void Update() {
        if (videoPlayer != null && !audioSource.isPlaying) {
            if (!videoStarted) {
                videoStarted = true;
                videoPlayer.Play();
            }

            if (Input.GetKeyDown(KeyCode.Space)) {
                if (!videoPlayer.isPlaying) {
                    videoPlayer.Play();
                } else {
                    videoPlayer.Pause();
                }
            } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                Rewind(tick);
            } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
                FastForward(tick);
            }
        }
    }

    public void PlayAudio() {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    public void LoadVideo(){
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer){
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            Debug.Log(videoPath);
            videoPlayer.url = videoPath;
        }
    }

    public void Rewind(float tick) {
        if (videoPlayer.time - tick > 0) {
            videoPlayer.time -= tick;
        } else {
            videoPlayer.time = 0;
        }
    }

    public void FastForward(float tick) {
        if (videoPlayer.time + tick < videoPlayer.length) {
            videoPlayer.time += tick;
        } else {
            videoPlayer.time = 0;
        }
    }

}
