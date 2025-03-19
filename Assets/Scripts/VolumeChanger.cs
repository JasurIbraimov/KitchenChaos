using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private Sprite[] images;
    [SerializeField] private Image stateImage;
    [SerializeField] Slider slider;
    public void Start()
    {
        slider.onValueChanged.AddListener(OnVolumeChanged);
    }
    public void OnVolumeChanged(float volume)
    {
        if (volume <= 0)
        {
            stateImage.sprite = images[0];
        }
        else if (volume > 0 && volume <= 0.4f)
        {
            stateImage.sprite = images[1];
        }
        else if (volume > 0.4f && volume <= 0.6f)
        {
            stateImage.sprite = images[2];
        }
        else
        {
            stateImage.sprite = images[3];
        }
    }
    private void OnDestroy()
    {
        slider?.onValueChanged.RemoveListener(OnVolumeChanged);
    }
}
