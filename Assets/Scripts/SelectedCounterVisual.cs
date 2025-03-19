using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private BaseCounter counter;
    [SerializeField] private GameObject[] selectedVisualGameObjectArray;
    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += OnSelectedCounterChangedHandler;
    }

    private void OnSelectedCounterChangedHandler(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == counter)
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
        foreach (var item in selectedVisualGameObjectArray)
        {
            item.gameObject.SetActive(true);
        }
    }

    private void Hide()
    {
        foreach (var item in selectedVisualGameObjectArray)
        {
            item.gameObject.SetActive(false);
        }
    }
}
