using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPgauge : MonoBehaviour
{
    public Slider slider;
    public GameObject ClearText;//�ꉞ

    private Rigidbody2D rigidBody;//��


    void Start()
    {
        slider.value = 20;
        rigidBody = GetComponent<Rigidbody2D>();//��
        // ClearText.SetActive(false);
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (x > 0)
        {
            rigidBody.AddForce(transform.right * 8.0f);
        }
        else if (x < 0)
        {
            rigidBody.AddForce(-transform.right * 8.0f);
        }
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

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            if (slider.value > 0)
            {
                slider.value--;
            }

            else
            {
                //ClearText.SetActive(true);

                EndingGame();

            }

        }
    }
}



