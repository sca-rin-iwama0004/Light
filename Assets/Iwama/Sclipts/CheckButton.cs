using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButton : test
{
  private string inputString;

   public TrainScript_a trainA;
   public TrainScript_b trainB;
   public TrainScript_c trainC;
   public GameObject KeyDoor;
   public GameObject newPanel;


    public string InputString {
        set { this.inputString = value; }
        get { return this.inputString; }
    }

    public override void Push_Button(int number)
    {
        this.inputString += number;
        Debug.Log(inputString);
        //base.Push_Button(number);

    }


    public void PushButtonCheck()
    {
        TrainScript_a A = trainA.GetComponent<TrainScript_a>();
        A.GetNumberA();//�}�b�v�ɉ��̐������łĂ邩

        TrainScript_b B = trainB.GetComponent<TrainScript_b>();
        B.GetNumberB();//�}�b�v�ɉ��̐������łĂ邩

        TrainScript_c C = trainC.GetComponent<TrainScript_c>();
        C.GetNumberC();//�}�b�v�ɉ��̐������łĂ邩

        int a = A.GetNumberA();
        int b = B.GetNumberB();
        int c = C.GetNumberC();

        int s = int.Parse(inputString);
        Debug.Log("�ۑ�����Ă��鐔�l" + s);

       int j = a * 100 + b * 10 + c;


       if (s == j) 
       {
           Debug.Log("����");
           Destroy(KeyDoor);
           newPanel.SetActive(false);

        }
        else{
           Debug.Log("�s����");
       }
       
        
    }
}
