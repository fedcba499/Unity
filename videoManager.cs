using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    public bool status  = true;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    
    public void Play()
    {
        videoPlayer.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
    }

    public void Stop()
    {
        videoPlayer.Stop();
    }

    public void playIntro()
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "Assets/beach.mp4";
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;

    }

    
    public void playBlast()
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "Assets/Paradise.mp4";
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;

    }

    public void playToggle()
    {
        if(status)
        {
            playBlast();
            status = false;
        }
        else
        {
            playIntro();
            status = true;
        }

    }

    private void VideoPlayer_prepareCompleted(VideoPlayer source)
    {
        Play();
    }


}
