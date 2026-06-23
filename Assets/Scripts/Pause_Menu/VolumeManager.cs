using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    // Chatgpt code anfang 
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private AudioSource musicSource;

    private void Start()
    {
        volumeSlider.value = musicSource.volume;

        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    private void ChangeVolume(float value)
    {
        musicSource.volume = value;
    }
    // Chatgpt code ende
}

