using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oxygen : MonoBehaviour
{
    public Slider slider;
    public GameObject ClearText;//�ꉞ

    private Rigidbody2D rigidBody;//��


    void Start()
    {
        slider.value = 100;
      
        // ClearText.SetActive(false);
    }

    void EndingGame()
    {
        //3�b��Ƀ��\�b�h�����s����
        Invoke("LoadEndingScene", 3);
    }

    void LoadEndingScene()
    {
        SceneManager.LoadScene("GamaOver");//�Q�[���I�[�o�[�̉��
    }

   
}


