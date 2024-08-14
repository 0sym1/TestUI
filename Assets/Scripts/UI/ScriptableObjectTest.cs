using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Data")]
public class ScriptableObjectTest : ScriptableObject
{
    [SerializeField] public Sprite image;
    [SerializeField] public string nameProfile;
    [SerializeField] public int ID;
}
