using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor.Search;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _bgmPlayer; //πË∞Ê¿Ωæ«
    public Queue<GameObject> _sefQueue;

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
        _sefQueue = new Queue<GameObject>();
        for (int i = 0; i < 5; i++)
        {
            GameObject obj = new GameObject();
            obj.AddComponent<AudioSource>();
            _sefQueue.Enqueue(obj);
            DontDestroyOnLoad(obj);
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
                PlaySefQueue(_sefQueue, _sef[i]);
                return;
            }
        }
    }
    private void PlaySefQueue(Queue<GameObject> sefQueue, AudioClip audioClip)
    {
        GameObject obj = sefQueue.Dequeue();
        obj.GetComponent<AudioSource>().clip = audioClip;
        obj.GetComponent<AudioSource>().Play();
        _sefQueue.Enqueue(obj);
    }
}
