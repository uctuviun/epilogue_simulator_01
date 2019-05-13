using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicmanager : MonoBehaviour {

public AudioSource AudioSource;
//public AudioSource SoundSource;
public AudioClip clip_1, clip_2, clip_3, clip_4, clip_5, clip_6;
//public AudioCLip static_1, static_2, static_3;
private static musicmanager instance = null;
public static musicmanager Instance {
     get { return instance; }
 }



//PlayerPrefs Int "backgroundMusic" 1(clip_1), 2(clip_2), 3(clip_3) are main music options,
//0, 4, 5 are null slots, 6(clip_4) is full threnody, 7(clip_5) is ancilla tone,
//8(clip_6) is harbinger tone

	void Awake() {
     if (instance != null && instance != this) {
         Destroy(this.gameObject);
         return;
     } else {
         instance = this;
     }
     DontDestroyOnLoad(this.gameObject);
 }

	// Use this for initialization
	void Start () {
//    AudioSource = GetComponentInChildren<AudioSource>();

	}

	// Update is called once per frame
	void Update () {
    if(PlayerPrefs.GetInt("soundOn") == 1){
      if(PlayerPrefs.GetInt("backgroundMusic") == 0){
        AudioSource.enabled = false;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 1){
        AudioSource.clip = clip_1;
        AudioSource.enabled = true;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 2){
        AudioSource.clip = clip_2;
        AudioSource.enabled = true;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 3){
        AudioSource.clip = clip_3;
        AudioSource.enabled = true;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 4){
        AudioSource.enabled = false;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 5){
        AudioSource.enabled = false;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 6){
        AudioSource.clip = clip_4;
        AudioSource.enabled = true;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 7){
        AudioSource.clip = clip_5;
        AudioSource.enabled = true;
      }
      if(PlayerPrefs.GetInt("backgroundMusic") == 8){
        AudioSource.clip = clip_6;
        AudioSource.enabled = true;
      }
      if(PlayerPrefs.GetInt("gameSpeed") == 3){
        AudioSource.pitch = 1f;
      }
      if(PlayerPrefs.GetInt("gameSpeed") == 2){
        AudioSource.pitch = .6f;
      }
      if(PlayerPrefs.GetInt("gameSpeed") == 1){
        AudioSource.pitch = .3f;
      }
      if(PlayerPrefs.GetInt("gameSpeed") == 4){
        AudioSource.pitch = 1.5f;
      }
    }
    if(PlayerPrefs.GetInt("soundOn") == 0){
      AudioSource.enabled = false;
    }
/*    if(PlayerPrefs.GetInt("gameTuning") == 3){
      SoundSource.clip = static_3;
      SoundSource.enabled = true;
    }
    if(PlayerPrefs.GetInt("gameTuning") == 2){
      SoundSource.clip = static_2;
      SoundSource.enabled = true;
    }
    if(PlayerPrefs.GetInt("gameTuning") == 1){
      SoundSource.clip = static_1;
      SoundSource.enabled = true;
    }*/
	}
}
