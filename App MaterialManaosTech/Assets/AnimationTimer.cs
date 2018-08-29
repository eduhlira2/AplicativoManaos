using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTimer : MonoBehaviour{

	public float TimeRemaining;
	public float TimeRemaining2;
	private bool TimeIsOver=false;
	public GameObject professor;
	private Animator professorAnim;

	// Use this for initialization
	void Start () {
		TimeRemaining2 = TimeRemaining;
		professorAnim=professor.GetComponent<Animator> ();
		professorAnim.SetBool ("Falar", true);
		professorAnim.SetBool ("Tchau", false);
	}

	// Update is called once per frame
	void Update () {
		/*if (DefaultTrackableEventHandler.zerar == true) {
			ZerarTudo ();
		}*/
		if (TimeIsOver == false) {
			professorAnim.SetBool ("Falar", true);
			professorAnim.SetBool ("Tchau", false);
		} else {
			professorAnim.SetBool ("Falar", false);
			professorAnim.SetBool ("Tchau", true);
		}

		if (TimeIsOver == false) {
			TimeRemaining2 -= Time.deltaTime;
			if (TimeRemaining2 <= 1.0f) {
				TimeIsOver = true;
			}
		}
	}

	void ZerarTudo(){
		TimeRemaining2 = TimeRemaining;
		TimeIsOver = false;
		professorAnim.SetBool ("Falar", true);
		professorAnim.SetBool ("Tchau", false);
		//DefaultTrackableEventHandler.zerar = false;
	}
}
