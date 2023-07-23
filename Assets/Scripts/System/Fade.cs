﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [Tooltip("フェードさせるUI")]
    [SerializeField]
    private Image _fadePanel;
    [Tooltip("実行時間")]
    [SerializeField]
    private float _fadeTime = 1f;

    private Action[] _onCompleteFadeIn = default;
    private Action[] _onCompleteFadeOut = default;

    public static Fade Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (_fadePanel) StartFadeIn();
    }

    public void StartFadeIn()
    {
        StartCoroutine(FadeIn());
    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeIn()
    {
        _fadePanel.gameObject.SetActive(true);

        //α値(透明度)を 1 -> 0 にする(少しずつ明るくする)
        float alpha = 1f;
        Color color = _fadePanel.color;

        while (alpha > 0f)
        {
            alpha -= Time.deltaTime * (1f / _fadeTime);

            if (alpha <= 0f) alpha = 0f;

            color.a = alpha;
            _fadePanel.color = color;
            yield return null;
        }

        _fadePanel.gameObject.SetActive(false);
        foreach (var action  in _onCompleteFadeIn)
        {
            action?.Invoke();
        }
    }

    private IEnumerator FadeOut()
    {
        _fadePanel.gameObject.SetActive(true);

        //α値(透明度)を 0 -> 1 にする(少しずつ暗くする)
        float alpha = 0f;
        Color color = _fadePanel.color;

        while (alpha < 1f)
        {
            alpha += Time.deltaTime * (1f / _fadeTime);

            if (alpha >= 1f) alpha = 1f;

            color.a = alpha;
            _fadePanel.color = color;
            yield return null;
        }

        foreach (var action in _onCompleteFadeOut)
        {
            action?.Invoke();
        }
    }

    #region フェード実行後に実行する関数を登録
    public void RegisterFadeInEvent(Action[] actions)
    {
        _onCompleteFadeIn = actions;
    }

    public void RegisterFadeOutEvent(Action[] actions)
    {
        _onCompleteFadeOut = actions;
    }
    #endregion
}