using System;
using UnityEngine;

public class TouchProcessor : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.touches[0];
            var camera = Camera.main;
            var wotldPosition = camera.ScreenToWorldPoint(touch.position);
            //Debug.Log($"x = {Math.Round(wotldPosition.x)}    y = {Math.Round(wotldPosition.y)}");
        }
    }
}