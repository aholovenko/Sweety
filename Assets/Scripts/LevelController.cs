using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
	public static LevelController current;

	public AudioClip music = null;
	AudioSource musicSourse = null;

	public GameObject settingdWindow;


	void Start(){
		musicSourse = gameObject.AddComponent<AudioSource>();
		musicSourse.clip = music;
		musicSourse.loop = true;
		musicSourse.Play ();
		musicSetting (SoundManager.IsMusicOn);
		soundSetting (SoundManager.IsSoundOn);

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


/*	Vector3 startingPosition;

	public bool rabbitIsDead = false;

	public UILabel coinsLabel;
	public GameObject settingsPrefab;

	int coins;
	int fruits;
	int crystals;


	void Awake(){
		current = this;
	}

	void Start(){
		coinsLabel.text = "0000";
	}


	public void onPauseClick(){
		GameObject parent = UICamera.first.transform.parent.gameObject;
		GameObject obj = NGUITools.AddChild(parent, settingsPrefab);
		Setting popup = obj.GetComponent<Setting>();
	}


	public void SetStartPosition(Vector3 position){
		this.startingPosition = position;
	}

	public bool isRabbitAlive(){
		return !rabbitIsDead;
	}

	public void OnRabbitDeath(Rabbit rabbit){
		rabbit.GetComponent<Animator> ().SetBool("die", true);
		rabbit.GetComponent<Rigidbody2D>().isKinematic = true;
		rabbit.GetComponent<BoxCollider2D> ().enabled = false;
		StartCoroutine (returnLater (rabbit));
		rabbitIsDead = true;
		Debug.Log ("Death Is Here");
		HealthUI.current.HealthLost ();
	}

	IEnumerator returnLater(Rabbit rabbit){
		yield return new WaitForSeconds (3);

		rabbitIsDead = false;

		rabbit.transform.position = this.startingPosition;
		rabbit.MakeNormalScale ();
		rabbit.GetComponent<Rigidbody2D>().isKinematic = false;
		rabbit.GetComponent<BoxCollider2D> ().enabled = true;
		rabbit.GetComponent<Animator> ().SetBool("die", false);
	}

	public void addCoins(int quantity){
		this.coins += quantity;
		coinsLabel.text = coins.ToString ("0000");

	}*/

}
