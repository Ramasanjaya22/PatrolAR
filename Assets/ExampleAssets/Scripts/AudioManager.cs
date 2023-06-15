using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void Awake()
    {
        // Membuat AudioManager menjadi singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Memutar audio pada saat game dimulai
        PlayAudio();
    }

    private void OnEnable()
    {
        // Mendaftarkan fungsi LoadScene ke event SceneManager.sceneLoaded
        SceneManager.sceneLoaded += LoadScene;
    }

    private void OnDisable()
    {
        // Membuang pendaftaran fungsi LoadScene dari event SceneManager.sceneLoaded
        SceneManager.sceneLoaded -= LoadScene;
    }

    private void LoadScene(Scene scene, LoadSceneMode mode)
    {
        // Memutar audio setiap kali scene berpindah
        PlayAudio();
    }

    private void PlayAudio()
    {
        // Memeriksa apakah audio source dan audio clip sudah di-assign
        if (audioSource != null && audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}

