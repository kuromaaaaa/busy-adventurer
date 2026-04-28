using System;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class FadeInOut : SingletonMonoBehavior<FadeInOut>
{
    
    [SerializeField] private Image _fadePanel;
    [SerializeField] private Ease _easing;

    private async void Start()
    {
        // テスト
        // await FadeInAsync(3);
        // Debug.Log("Fade In");
    }


    public void FadeIn(float time, Action onFadeInComplete)
    {
        _fadePanel.DOFade(0, time).OnComplete(() => 
            {onFadeInComplete?.Invoke(); }).SetEase(_easing);
    }

    public async UniTask FadeInAsync(float time)
    {
        await _fadePanel.DOFade(0, time).SetEase(_easing);
    }

    public void FadeOut(float time, Action onFadeOutComplete)
    {
        _fadePanel.DOFade(1, time).OnComplete(() =>
            {onFadeOutComplete?.Invoke(); }).SetEase(_easing);
    }

    public async UniTask FadeOutAsync(float time)
    {
        await _fadePanel.DOFade(1, time).SetEase(_easing);
    }
}
