using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour {
	public Text countText;
	public Slider brightnessSlider;
	public Image brightnessSliderBackground;
	public Image brightnessSliderImage;
	public Image brightnessSliderHandle;
	public Image resetButton;
	public Image subtractButton;
	public Image countButton;

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("LastSave")) {
			PlayerPrefs.SetInt ("LastSave",0);
		}
		countText.text = PlayerPrefs.GetInt ("LastSave").ToString();
	}

	public void Increment(){
		Handheld.Vibrate ();
		PlayerPrefs.SetInt ("LastSave", PlayerPrefs.GetInt ("LastSave")+1);
		countText.text = PlayerPrefs.GetInt ("LastSave").ToString();
	}

	public void Reset(){
		Handheld.Vibrate ();
		PlayerPrefs.SetInt ("LastSave", 0);
		countText.text = PlayerPrefs.GetInt ("LastSave").ToString();
	}

	public void Decrement(){
		Handheld.Vibrate ();
		if(PlayerPrefs.GetInt("LastSave")>0)
			PlayerPrefs.SetInt ("LastSave", PlayerPrefs.GetInt ("LastSave")-1);
		countText.text = PlayerPrefs.GetInt ("LastSave").ToString();
	}	

	public void Brightness(){
		countButton.color = new Color (countButton.color.r, countButton.color.g, countButton.color.b, 1f * brightnessSlider.value);
		countText.color = new Color (countText.color.r, countText.color.g, countText.color.b, 1f * brightnessSlider.value);
		resetButton.color = new Color (resetButton.color.r, resetButton.color.g, resetButton.color.b, 1f * brightnessSlider.value);
		subtractButton.color = new Color (subtractButton.color.r, subtractButton.color.g, subtractButton.color.b, 1f * brightnessSlider.value);
		brightnessSliderBackground.color = new Color (brightnessSliderBackground.color.r, brightnessSliderBackground.color.g, brightnessSliderBackground.color.b, 1f * brightnessSlider.value); 
		brightnessSliderImage.color = new Color (brightnessSliderImage.color.r, brightnessSliderImage.color.g, brightnessSliderImage.color.b, 1f * brightnessSlider.value);
		if (brightnessSlider.value >= 0.5)
			brightnessSliderHandle.color = new Color (brightnessSliderHandle.color.r, brightnessSliderHandle.color.g, brightnessSliderHandle.color.b, 1f * brightnessSlider.value);
	}	


}
