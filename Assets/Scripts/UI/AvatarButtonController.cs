using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    private Image image;
    private Button button;

    void Awake(){
        image = GetComponent<Image>();
        button = GetComponent<Button>();
    }
    void Start(){
        button.onClick.AddListener(()=>{
            HomeController.Instance.ChangeAvt(image);
        });
    }
}
