using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] private AudioSource _musicSource, _effectSource;

    private void Awake()
    {
        if(Instance == null)
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    public void PlaySound(AudioClip _clip)
    {
        _effectSource.PlayOneShot(_clip);
    }

    public void StopSound(AudioClip _clip)
    {
        _effectSource.Stop();
    }


}
