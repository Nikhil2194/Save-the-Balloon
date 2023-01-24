using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using UnityEngine.SceneManagement;

public class ManagerUI : MonoBehaviour
{
    [SerializeField] GameObject colourWheel, cloud1, cloud2, cloud3, cloud4, Spike1, Spike2, Title, StartButton;

    public Spline mySpline;
    public Transform Parachute;
    [SerializeField] public GameObject explosionBalloon;

    void Awake()
    {
        Tween.Spline(mySpline, Parachute, 0, 1, false, 12, 0, Tween.EaseInOut, Tween.LoopType.PingPong);
    }

    void Start()
    {
        LeanTween.rotate(colourWheel, new Vector3(0, 0, 90), 9f).setDelay(2.11f).setLoopPingPong();
        LeanTween.move(cloud1, new Vector3(5.8f, -7.44f, 0), 1.0f).setDelay(1.1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.move(cloud2, new Vector3(-3.98f, 9.74f, 0), 1.0f).setDelay(1.6f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.move(cloud3, new Vector3(4.58f, 10.14f, 0), 1.0f).setDelay(1.1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.move(cloud4, new Vector3(-6.78f, -4.14f, 0), 1.0f).setDelay(1.4f).setEase(LeanTweenType.easeInOutBack);

        LeanTween.move(Spike1, new Vector3(-2.2f, 7.85f, 0), 3.5f).setDelay(3.6f).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.move(Spike2, new Vector3(2.3f, -6f, 0), 6.5f).setDelay(3.6f).setEase(LeanTweenType.easeInOutQuad);

        LeanTween.move(Title, new Vector3(0, 4.8f, 0f), 0.5f).setDelay(3.2f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.scale(Title, new Vector3(1.2f, 1.2f, 1.2f), 2.95f).setDelay(4.15f).setEase(LeanTweenType.easeInOutBack);

        LeanTween.scale(StartButton, new Vector2(2.13f, 3.58f), 1f).setDelay(4.498f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        explosionBalloon.SetActive(true);
    }

}
