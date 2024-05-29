using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tasks : MonoBehaviour
{
    // Start is called before the first frame update
    public bool task1;
    public bool task2;
    public bool task3;
    public bool task4;
    
    public UnityEngine.UI.Image heart1;
    public UnityEngine.UI.Image heart2;
    public UnityEngine.UI.Image heart3;
    public UnityEngine.UI.Image heart4;
    
    public void TaskComplete(int id)
    {
        if (id == 1)
        {
            task1 = !task1;
            heart1.color = task1? Color.red: Color.white;
        }else if (id == 2)
        {
            task2 = !task2;
            heart2.color = task2? Color.red: Color.white;
        }else if (id == 3)
        {
            task3 = !task3;
            heart3.color = task3? Color.red: Color.white;
        }else if (id == 4)
        {
            task4 = !task4;
            heart4.color = task4? Color.red: Color.white;
        }
    }
}
