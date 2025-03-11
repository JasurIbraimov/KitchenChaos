using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject selectedVisualGameObject;
    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += OnSelectedCounterChangedHandler;
    }

    private void OnSelectedCounterChangedHandler(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == clearCounter)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        if (selectedVisualGameObject != null)
        {
            selectedVisualGameObject.SetActive(true);
        }
    }

    private void Hide()
    {
        if (selectedVisualGameObject != null)
        {
            selectedVisualGameObject.SetActive(false);
        }
    }
}
