using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class menu_hover_options : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,
 		IPointerClickHandler{

	public Image myImage;
	public Sprite mySprite0, mySprite1, mySprite2, mySprite3, full_threnody, ancilla_tone,
  harbinger_tone, hope;
	public bool re_re, tone, speed, tuning, light, sound;
	bool within = false;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		while(within){

		}

	}

	public void OnPointerEnter(PointerEventData eventData)
    {

			if(re_re == true){
				myImage.sprite = mySprite0;
				myImage.enabled = true;
			}
			if(tone == true){
				if(PlayerPrefs.GetInt("backgroundMusic") == 0){
					myImage.sprite = mySprite0;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("backgroundMusic") == 1){
					myImage.sprite = mySprite1;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("backgroundMusic") == 2){
					myImage.sprite = mySprite2;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("backgroundMusic") == 3){
					myImage.sprite = mySprite3;
					myImage.enabled = true;
				}
        if(PlayerPrefs.GetInt("backgroundMusic") == 4){
					myImage.sprite = mySprite0;
					myImage.enabled = true;
				}
        if(PlayerPrefs.GetInt("backgroundMusic") == 5){
					myImage.sprite = mySprite0;
					myImage.enabled = true;
				}
        if(PlayerPrefs.GetInt("backgroundMusic") == 6){
          myImage.sprite = full_threnody;
          myImage.enabled = true;
        }
        if(PlayerPrefs.GetInt("backgroundMusic") == 7){
          myImage.sprite = ancilla_tone;
          myImage.enabled = true;
        }
        if(PlayerPrefs.GetInt("backgroundMusic") == 8){
          myImage.sprite = harbinger_tone;
          myImage.enabled = true;
        }
			}
			if(speed == true){
				if(PlayerPrefs.GetInt("gameSpeed") == 1){
					myImage.sprite = mySprite1;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("gameSpeed") == 2){
					myImage.sprite = mySprite2;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("gameSpeed") == 3){
					myImage.sprite = mySprite3;
					myImage.enabled = true;
				}
        if(PlayerPrefs.GetInt("gameSpeed") == 4){
          myImage.sprite = hope;
          myImage.enabled = true;
        }
			}
			if(tuning == true){
				if(PlayerPrefs.GetInt("gameTuning") == 1){
					myImage.sprite = mySprite1;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("gameTuning") == 2){
					myImage.sprite = mySprite2;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("gameTuning") == 3){
					myImage.sprite = mySprite3;
					myImage.enabled = true;
				}
			}
			if(light == true){
				if(PlayerPrefs.GetInt("gameLight") == 1){
					myImage.sprite = mySprite1;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("gameLight") == 2){
					myImage.sprite = mySprite2;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("gameLight") == 3){
					myImage.sprite = mySprite3;
					myImage.enabled = true;
				}
			}
			if(sound == true){
				if(PlayerPrefs.GetInt("soundOn") == 0){
					myImage.sprite = mySprite0;
					myImage.enabled = true;
				}
				if(PlayerPrefs.GetInt("soundOn") == 1){
					myImage.sprite = mySprite1;
					myImage.enabled = true;
				}
			}
    }

		public void OnPointerClick(PointerEventData eventData)
			{

				if(re_re == true){
					myImage.sprite = mySprite0;
					myImage.enabled = true;
				}
				if(tone == true){
					if(PlayerPrefs.GetInt("backgroundMusic") == 0){
						myImage.sprite = mySprite0;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("backgroundMusic") == 1){
						myImage.sprite = mySprite1;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("backgroundMusic") == 2){
						myImage.sprite = mySprite2;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("backgroundMusic") == 3){
						myImage.sprite = mySprite3;
						myImage.enabled = true;
					}
          if(PlayerPrefs.GetInt("backgroundMusic") == 4){
  					myImage.sprite = mySprite0;
  					myImage.enabled = true;
  				}
          if(PlayerPrefs.GetInt("backgroundMusic") == 5){
  					myImage.sprite = mySprite0;
  					myImage.enabled = true;
  				}
				}
				if(speed == true){
					if(PlayerPrefs.GetInt("gameSpeed") == 1){
						myImage.sprite = mySprite1;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("gameSpeed") == 2){
						myImage.sprite = mySprite2;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("gameSpeed") == 3){
						myImage.sprite = mySprite3;
						myImage.enabled = true;
					}
				}
				if(tuning == true){
					if(PlayerPrefs.GetInt("gameTuning") == 1){
						myImage.sprite = mySprite1;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("gameTuning") == 2){
						myImage.sprite = mySprite2;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("gameTuning") == 3){
						myImage.sprite = mySprite3;
						myImage.enabled = true;
					}
				}
				if(light == true){
					if(PlayerPrefs.GetInt("gameLight") == 1){
						myImage.sprite = mySprite1;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("gameLight") == 2){
						myImage.sprite = mySprite2;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("gameLight") == 3){
						myImage.sprite = mySprite3;
						myImage.enabled = true;
					}
				}
				if(sound == true){
					if(PlayerPrefs.GetInt("soundOn") == 0){
						myImage.sprite = mySprite0;
						myImage.enabled = true;
					}
					if(PlayerPrefs.GetInt("soundOn") == 1){
						myImage.sprite = mySprite1;
						myImage.enabled = true;
					}
				}
			}

	public void OnPointerExit(PointerEventData eventData)
    {
				myImage.enabled = false;

    }
}
