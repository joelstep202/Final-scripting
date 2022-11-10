using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grupo : MonoBehaviour
{
    [SerializeField] private AudioSource sfx, ambient;

    public static grupo Instance { get; private set; }
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    public void ActivarSonido(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }
    public void Sonido()
    {
        sfx.Play();
    }
    public void Adios()
    {
        sfx.Stop();
    }
    public void Sonidofuente(AudioClip clip)
    {
        ambient.PlayOneShot(clip);
    }
}
