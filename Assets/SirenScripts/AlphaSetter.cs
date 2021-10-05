using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaSetter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    public void SetAlpha(float value)
    {
        _renderer.color = new Color(_renderer.color.r, _renderer.color.g, _renderer.color.b, value);
    }
}
