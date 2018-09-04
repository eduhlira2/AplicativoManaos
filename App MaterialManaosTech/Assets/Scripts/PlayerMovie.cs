using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayerMovie : MonoBehaviour {

    //public Button playButton;
    
    public VideoPlayer player;
    public GameObject playButton;
    public GameObject PauseButtonInvisible;

    public GameObject fullscreen;
    public GameObject MainObject;
    public VideoPlayer FullScreenPlayer;
    public GameObject FullScreenControl;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    public void Play()
    {
        
        player.Play();
        playButton.SetActive(false);
        PauseButtonInvisible.SetActive(true);
              
    }

    public void Pause()
    {
        player.Pause();
        PauseButtonInvisible.SetActive(false);
        playButton.SetActive(true);
    }

    public void FullScreen()
    {
        FullScreenPlayer.frame = player.frame;
       fullscreen.SetActive(true);

        player.Pause();
        Debug.Log("Pausou o negocio");
        PauseButtonInvisible.SetActive(false);
        playButton.SetActive(true);
        
        //MainObject.SetActive(false);
        FullScreenControl.SetActive(true);
    }

    public void FullScreenExit()
    {
        player.frame = FullScreenPlayer.frame;
        fullscreen.SetActive(false);
        FullScreenControl.SetActive(false);
       
    }
  }
