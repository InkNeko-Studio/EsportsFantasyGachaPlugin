using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GachaManager : MonoBehaviour
{
    public static GachaManager Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        
        DontDestroyOnLoad(gameObject);
    }

    public List<GachaItem> items;

    public Prize nothing;

    private void Start()
    {
        foreach (var item in items)
        {
            item.percentage = PlayerPrefs.GetFloat(item.prize.name, item.percentage);
        }
    }

    public Prize RunGacha()
    {
        float number = Random.Range(0.1f, 100f);
        float accumulator = 0f;
        foreach (var item in items)
        {
            accumulator += item.percentage;
            if (accumulator >= number)
                return item.prize;
        }

        return nothing;
    }

    [ContextMenu("Test")]
    public void Test()
    {
        int baker = 0;
        int doce = 0;
        int nada = 0;
        for (int i = 0; i < 10000; i++)
        {
            var prize = RunGacha();
            
            if (prize.name == "Baker")
                baker++;
            if (prize.name == "Doce")
                doce++;
            if (prize.name == "Nada")
                nada++;
        }
        
        Debug.Log($"Baker: {(float)baker/10000f}");
        Debug.Log($"Doce: {(float)doce/10000f}");
        Debug.Log($"Nada: {(float)nada/10000f}");
    }
}
