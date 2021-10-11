using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject CanvasWin;
    public Text scoreText;
    int score;
    public float Maxscore = 10f;
    public GameObject Arrow;
    public GameObject MusicBackground;
    public bool GameAktif = true;
    public float Waktu;
    
    float s;

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
    }
    private void Update()
    {
        if (GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }


        scoreText.text = score.ToString();

        if (score == 50 )
        {
            Debug.Log("You WIN!");
            CanvasWin.SetActive(true);
            Arrow.SetActive(false);
            MusicBackground.SetActive(false);
            PlaySound.Instance.PlaySFX("win");
            GameAktif = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bubble"))
        {
            Destroy(collision.gameObject);
            score++;
            PlaySound.Instance.PlaySFX("bubble");
        }
    }


}
