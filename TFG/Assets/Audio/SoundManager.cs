using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioClip[] audios;

    private AudioSource controlaudio;

    private void Awake()
    {
        controlaudio = GetComponent<AudioSource>();
    }

    public void SeleccionAudio(int indice, float volumen)
    {
        controlaudio.PlayOneShot(audios[indice], volumen);
    }
}
