using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewSpeaker", menuName = "Data/New Speaker")]
[System.Serializable]
public class Speaker : ScriptableObject
{
    public string speakerName;
    public Color textColor;

    public List<Sprite> sprites;
    public SpriteController prefab;

    // New Variable
    public bool isDisplayed;

    // New Function
    public void hideSprite() {
        isDisplayed = false;
    }

}
