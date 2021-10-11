using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroySquare : MonoBehaviour
{
    public Text scoreText;
    int score;

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("square"))
        {
            Destroy(collision.gameObject);
            score++;
        }
    }
}
