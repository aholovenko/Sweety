using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
	public static LevelController current;

	public GameObject ghost;

	int elixir =3;
	int donut = 0;

	public AudioClip music = null;
	AudioSource musicSourse = null;

	public GameObject settingdWindow;
	public GameObject looseWindow;

	public UILabel donutsLabel;
	int speedQuantity = 5;

	void Awake(){
		current = this;
	}


	void Start(){
		musicSourse = gameObject.AddComponent<AudioSource>();
		musicSourse.clip = music;
		musicSourse.loop = true;
		musicSourse.Play ();
		musicSetting (SoundManager.IsMusicOn);
		soundSetting (SoundManager.IsSoundOn);

	}

	void Update(){
		if (donut >= speedQuantity) {
			Ghost.current.MakeFaster ();
			speedQuantity += 10;
		}
	}

	public void musicSetting(bool is_music_on){
		Debug.Log ("Set sound : " + is_music_on);
		if (is_music_on) {
			musicSourse.Play ();
		} else { musicSourse.Stop ();
		}
	}

	public void soundSetting(bool is_sound_on){
		Debug.Log ("Set sound : " + is_sound_on);
		SoundManager.IsSoundOn = is_sound_on;
	}

	public void onSettingClick(){
		settingdWindow.SetActive(true);
	}

	public void onChooseLevelClick(){
		SceneManager.LoadScene ("Level1");
	}
		

	public void elixirLost(){
		elixir--;
		if (elixir == 0) {
			OnGhostDeath (Ghost.current);

			//looseWindow.SetActive (true);
		}
	}

	IEnumerator onLooseWindow(){
		yield return new WaitForSeconds (1f);
		looseWindow.SetActive (true);
	}

	public void addDonut(){
		donut++;
		donutsLabel.text = donut.ToString ("0000");
	}

	public void OnGhostDeath(Ghost ghost){
		ghost.GetComponent<Animator> ().SetBool ("die", true);
		ghost.GetComponent<Rigidbody2D> ().isKinematic = true;
		ghost.verticalSpeed = 0;
		ghost.horizontalSpeed = 0;
		StartCoroutine (onLooseWindow ());
		//this.ghost.SetActive (false);

	}
		
}
