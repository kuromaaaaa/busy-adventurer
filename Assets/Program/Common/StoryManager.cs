using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class StoryManager : MonoBehaviour
{ 
    [SerializeField] TalkList talkList;
    private IEnumerator<TalkData> talkEnumerator;
    
    Tween _tween;

    private void Start()
    {
        talkEnumerator = talkList.talkList.GetEnumerator();
    }
    
    
    public void NextTalk()
    {
        if (talkEnumerator.MoveNext())
        {
            TalkData talkData = talkEnumerator.Current;
            Debug.Log($"{talkData.character.ToString()}: { talkData.text}");
        }
        else
        {
            Debug.Log("End of Talk");
        }
    }

    public void ViewUpdate()
    {
        
    }
    
}
