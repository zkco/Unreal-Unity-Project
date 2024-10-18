using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _bgmPlayer; //배경음악
    [SerializeField] private AudioSource _sefPlayer; //효과음

    [SerializeField] private AudioClip[] _bgm;
    [SerializeField] private AudioClip[] _sef;

    private static SoundManager instance;
    public static SoundManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance.GetComponent<SoundManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(SoundManager).Name;
                    instance = obj.AddComponent<SoundManager>();
                }
            }

            DontDestroyOnLoad(instance);
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    private void Start()
    {
        PlayBgm("OtherSceneBGM");
    }

    public void PlayBgm(string soundName)
    {
        for (int i = 0; i < _bgm.Length; i++)
        {
            if (_bgm[i].name == soundName)
            {
                _bgmPlayer.clip = _bgm[i];
                _bgmPlayer.Play();
                return;
            }
        }
    }

    public void StopBgm()
    {
        _bgmPlayer.Stop();
    }

    public void PlaySef(string soundName)
    {
        for (int i = 0; i < _sef.Length; i++)
        {
            if (_sef[i].name == soundName)
            {
                _sefPlayer.clip = _bgm[i];
                _sefPlayer.Play();
                return;
            }
        }
        _sefPlayer = null;
    }

    public bool isPlaying(string clipName) //"bgm", "sef"
    {
        switch (clipName)
        {
            case "bgm": 
                if(_bgmPlayer == null)
                {
                    return false;
                }
                else return true;
            case "sef":
                if (_sefPlayer == null)
                {
                    return false;
                }
                else return true;
            default: return false;
        }
    }
}
