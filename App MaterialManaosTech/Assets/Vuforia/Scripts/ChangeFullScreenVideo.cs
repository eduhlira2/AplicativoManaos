using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeFullScreenVideo : MonoBehaviour {

    public VideoPlayer fullScreen;
    public GameObject videoAtual;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeVideo( VideoClip clipAtual)
    {
        fullScreen.clip = clipAtual;
        
    }
}
