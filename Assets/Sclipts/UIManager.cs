using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class UIManager : MonoBehaviour
{
    //�R��Panel���i�[����ϐ�
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        //BackToMenu���\�b�h���Ăяo��
     //   BackToMenu();
    }

    
    void OnCollisionEnter2D(Collision2D Collision)
    {
      
            Panel.SetActive(true);
      
    }

}