using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tmp : MonoBehaviour
{
    public ScriptableObjectTest tftf;
    [SerializeField] private Image avatarHome;
    [SerializeField] private Image avatarPanel;
    private Button button;
    public static int abc;

    void Awake(){
        button = GetComponent<Button>();
    }
    void Start(){
        button.onClick.AddListener(()=>{
            print();
        });
    }
    public void print(){
        abc = tftf.ID;
        avatarPanel.sprite = tftf.image;
    }
}
