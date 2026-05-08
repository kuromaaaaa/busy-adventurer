using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TalkList", menuName = "Scriptable Objects/TalkList")]
public class TalkList : ScriptableObject
{
    public List<TalkData> talkList = new List<TalkData>();
}

[System.Serializable]
public class TalkData
{
    public CharacterType character;
    public string text;
}

public enum CharacterType
{
    Player,
    King
}