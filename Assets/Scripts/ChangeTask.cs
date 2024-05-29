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
        task1.text = "O professor Wilson deve dar nota a mais por esta tarefa";
        task2.text = "O professor Wilson tem que dar 100 conto no pix para cada membro";
        task3.text = "O professor Wilson deve pegar leve na avaliacao de modelagem";
        task4.text = "acabou as ideias para o professor Wilson";
        button.text = "VISITANTES";
    }
    public void ChangeNormal()
    {
        task1.text = "Siga nossa pagina no Instagram";
        task2.text = "Siga nossa Pagina no X/Twitter";
        task3.text = "Assista a apresentacao por completo";
        task4.text = "Chame um amigo para participar";
        button.text = "PROFESSORES";
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
}
