using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _sounds;
    private void OnEnable()
    {
        EventManager.PlaySound += PlaySounds;
    }

    private void OnDisable()
    {
        EventManager.PlaySound -= PlaySounds;
    }

    /// <summary>
    /// id 0 - звук топора по дереву
    /// </summary>
    /// <param name="indexClip"></param>
    private void PlaySounds(int indexClip)
    {
        _audioSource.PlayOneShot(_sounds[indexClip]);
    }


}
