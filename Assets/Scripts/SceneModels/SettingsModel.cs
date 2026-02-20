using UnityEngine;
using TMPro;
public class SettingsModel : MonoBehaviour
{

    public static SettingsModel instance = new SettingsModel();


    public TMP_InputField inputName;

    public void SetInputName()
    {
        PlayerRefs.SetString("UserName", inputName.text);
    } 

    private SettingsModel()
    {
        if (instance == null)
        {
            instance = new SettingsModel();
        }
        return instance;
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
