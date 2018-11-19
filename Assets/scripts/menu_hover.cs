using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class menu_hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Image myImage;
	public Sprite mySprite;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnPointerEnter(PointerEventData eventData)
    {
				myImage.sprite = mySprite;
				myImage.enabled = true;
    }
	public void OnPointerExit(PointerEventData eventData)
    {
				myImage.enabled = false;

    }
}
