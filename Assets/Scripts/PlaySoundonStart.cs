using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundonStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
     void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
        SoundManager.Instance.StopSound(_clip );
    }
}
