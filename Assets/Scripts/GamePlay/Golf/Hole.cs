using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    bool entered = false;
    [SerializeField] GameObject ball;
    [SerializeField] GameObject score;
    [SerializeField] GameObject panel;
    [SerializeField] AudioSource bolaMasukLubang;

    public bool Entered { get => entered; }

    private void OnTriggerEnter(Collider other)
    {
        entered = true;
        ball.SetActive(false);
        score.SetActive(false);
        panel.SetActive(true);
        bolaMasukLubang.Play();
        Debug.Log("ENTER");
    }
}
