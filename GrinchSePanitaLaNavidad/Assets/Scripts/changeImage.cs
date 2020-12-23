using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeImage : MonoBehaviour
{
    public AudioSource source { get { return GetComponent<AudioSource>(); } }    
    public Sprite i1;
    public Sprite a2;
    public Sprite i3;
    public Sprite i4;
    public Sprite i5;
    public Sprite i6;
    public Sprite i7;
    public Sprite i8;
    public Sprite i9;
    public Sprite i10;
    public Sprite i11;
    public Sprite i12;
    public Sprite i13;

    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public AudioClip clip9;
    public AudioClip clip10;
    public AudioClip clip11;
    public AudioClip clip12;
    public AudioClip clip13;
    public Button boton;

    public Image imageChange;
    public int buttonValue = 1;
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        //boton.onClick.AddListener(ChangeImage);
        imageChange.sprite = i1;
    }

    public void ChangeImage() {
        buttonValue++;

        switch (buttonValue)
        {
            case 1:
                imageChange.sprite = i1;
                break;
            case 2:
                imageChange.sprite = a2;
                source.PlayOneShot(clip2);
                break;
            case 3:
                imageChange.sprite = i3;
                source.PlayOneShot(clip3);
                break;
            case 4:
                imageChange.sprite = i4;
                source.PlayOneShot(clip4);
                break;
            case 5:
                imageChange.sprite = i5;
                source.PlayOneShot(clip5);
                break;
            case 6:
                imageChange.sprite = i6;
                source.PlayOneShot(clip6);
                break;
            case 7:
                imageChange.sprite = i7;
                source.PlayOneShot(clip7);
                break;
            case 8:
                imageChange.sprite = i8;
                source.PlayOneShot(clip8);
                break;
            case 9:
                imageChange.sprite = i9;
                source.PlayOneShot(clip9);
                break;
            case 10:
                imageChange.sprite = i10;
                source.PlayOneShot(clip10);
                break;
            case 11:
                imageChange.sprite = i11;
                source.PlayOneShot(clip11);
                break;
            case 12:
                imageChange.sprite = i12;
                source.PlayOneShot(clip12);
                break;
            case 13:
                imageChange.sprite = i13;
                source.PlayOneShot(clip13);
                break;
            case 14:
                SceneManager.LoadScene("modos");
                break;
            default:
                break;
        }

    }
}
