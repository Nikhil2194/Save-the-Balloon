using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Parachute : MonoBehaviour
{
    public float velocity = 1f;
    private Rigidbody2D rb;

    public TextMeshProUGUI scoreText;
    private int score;
    [SerializeField] public GameObject explosionBalloon;
    [SerializeField] public AudioClip scoreUpSound , GameOverSound,bgm;
    [SerializeField] public GameObject  taptext;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        explosionBalloon.SetActive(false);
        SoundManager.Instance.PlaySound(bgm);
         LeanTween.scale(taptext, new Vector3(1.1f, 1.1f, 1.1f), 1.59f).setLoopPingPong();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }

        RotateBalloon();
       
    }


    void ScoreUp()
    {
        score++;
        scoreText.text ="Score: "+ score.ToString();
        SoundManager.Instance.PlaySound(scoreUpSound);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ScoreRadar"))
        { 
            ScoreUp();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spike" || collision.gameObject.tag == "Wall")
        {
            explosionBalloon.SetActive(true);
            RestartGame();
            SoundManager.Instance.StopSound(bgm);
            SoundManager.Instance.PlaySound(GameOverSound);
        }
    }

  


    public void RestartGame()
    {
        SceneManager.LoadScene("GameOver");
    }


    public void RotateBalloon()
    {
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * 12f, 30) - 30);
    }
}
