using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HomeController : MonoBehaviour
{
    // Start is called before the first frame update
    public static HomeController Instance;
    [SerializeField] private GameObject profilePanel;
    [SerializeField] private Image avatarHome;
    [SerializeField] private Image avatarPanel;
    [SerializeField] private TextMeshProUGUI nameInputText;
    [SerializeField] private TextMeshProUGUI namePlayerText;
    private Image avtPresent;

    public ScriptableObjectTest[] array;
    
    void Awake(){
        avtPresent = gameObject.AddComponent<Image>();
        // avtPresent.sprite = avatarHome.sprite;
        // nameInputText.text = namePlayerText.text;
        Instance = this;
    }
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("IDProfile"));
        avtPresent.sprite = array[PlayerPrefs.GetInt("IDProfile")].image;
        nameInputText.text = array[PlayerPrefs.GetInt("IDProfile")].name;
        namePlayerText.text = nameInputText.text;
        avatarHome.sprite = avtPresent.sprite;
        avatarPanel.sprite = avtPresent.sprite;
        profilePanel.SetActive(false);
    }

    public void OpenProfilePanel(){
        profilePanel.SetActive(true);
    }
    public void SaveProfile(){
        avtPresent.sprite = avatarPanel.sprite;
        namePlayerText.text = nameInputText.text;

        Debug.Log(tmp.abc);
        PlayerPrefs.SetInt("IDProfile", tmp.abc);

        
    }
    public void ChangeAvt(Image image){
        avatarPanel.sprite = image.sprite;
    }
    public void Esc(){
        profilePanel.SetActive(false);
        avatarHome.sprite = avtPresent.sprite;
        avatarPanel.sprite = avtPresent.sprite;
    }
}
