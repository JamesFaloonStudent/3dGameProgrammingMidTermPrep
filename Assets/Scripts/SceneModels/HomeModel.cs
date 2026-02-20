using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HomeModel : MonoBehaviour
{

    public TMP_InputField nameInputField;
    public TMP_Dropdown languageDropDown;
    public Slider speedSlider;
    public Button playGame;

    // Save the player's preferences when the play game button is clicked
    public void OnSubmit()
    {
        PlayerPrefs.SetString("PlayerName", nameInputField.text);
        PlayerPrefs.SetInt("Language", languageDropDown.value);
        PlayerPrefs.SetFloat("Speed", speedSlider.value);
        PlayerPrefs.Save();
    }
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
