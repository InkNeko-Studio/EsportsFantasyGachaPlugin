using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTask : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text task1;
    public TMP_Text task2;
    public TMP_Text task3;
    public TMP_Text task4;
    public TMP_Text button;
    
    public string inputtask1 = "Siga nossa pagina no Instagram";
    public string inputtask2 = "Siga nossa Pagina no X/Twitter";
    public string inputtask3 = "Assista a apresentacao por completo";
    public string inputtask4 = "Chame um amigo para participar";
    
    public string protask1 = "willson";
    public string protask2 = "willson";
    public string protask3 = "willson";
    public string protask4 = "willson";

    public TMP_InputField in1;
    public TMP_InputField in2;
    public TMP_InputField in3;
    public TMP_InputField in4;
    
    public TMP_InputField prin1;
    public TMP_InputField prin2;
    public TMP_InputField prin3;
    public TMP_InputField prin4;
    
    public bool professores;
    void Start()
    {
        ChangeNormal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTeacher()
    {
        task1.text = protask1;
        task2.text = protask2;
        task3.text = protask3;
        task4.text = protask4;
    }
    public void ChangeNormal()
    {
        task1.text = inputtask1;
        task2.text = inputtask2;
        task3.text = inputtask3;
        task4.text = inputtask4;
    }

    public void ToChange()
    {
        if (professores == false)
        {
            ChangeTeacher();
            professores = true;
        }else if (professores)
        {
            ChangeNormal();
            professores = false;
        }
    }

    public void ChangeTextNormal()
    {
        inputtask1 = in1.text;
        inputtask2 = in2.text;
        inputtask3 = in3.text;
        inputtask4 = in4.text;
        ChangeNormal();
    }
    public void ChangeTextProfessor()
    {
        protask1 = prin1.text;
        protask2 = prin2.text;
        protask3 = prin3.text;
        protask4 = prin4.text;
        ChangeTeacher();;
    }
}
