using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ButtonManager : MonoBehaviour
{
    public GameObject Sphere;
    public VideoClip Clip01;
    public VideoClip Clip02;
    public GameObject Button01;
    public GameObject Button02;

    public void ToVideoScene()
    {
        SceneManager.LoadScene("360Video");
    }

    public void GoIn()
    {
        Button01.SetActive(false);
        Button02.SetActive(true);
        Sphere.GetComponent<VideoPlayer>().clip = Clip01;
    }
    public void GoOut()
    {
        Button01.SetActive(true);
        Button02.SetActive(false);
        Sphere.GetComponent<VideoPlayer>().clip = Clip02;
    }
}
