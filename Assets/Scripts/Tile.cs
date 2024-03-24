using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.PackageManager;
using System;

public class Tile : MonoBehaviour
{

    [Serializable]
    public class State
    {
        public Color FillColor;
        public Color OutlineColor;
    }

    public State state { get; private set; }

    private TextMeshProUGUI text;
    private Image Fill;
    private Outline outline;
    public char letter { get; private set; }

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        Fill = GetComponent<Image>();
        outline = GetComponent<Outline>();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        text.text = letter.ToString();
    }
    public void SetState(State _state)
    {
        state = _state;
        Fill.color = state.FillColor;
        outline.effectColor = state.OutlineColor;
    }


}
