using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrizeDisplay : MonoBehaviour
{
    public GameObject prizePrefab;

    public Tasks tasks;

    public Prize nothing;
    
    public void Gacha()
    {
        Clear();
        
        int number = 0;
        number += tasks.task1 ? 1 : 0;
        number += tasks.task2 ? 1 : 0;
        number += tasks.task3 ? 1 : 0;
        number += tasks.task4 ? 1 : 0;

        var sticker = false;
        
        for (int i = 0; i < number; i++)
        {
            var gb = Instantiate(prizePrefab, transform);
            var image = gb.GetComponent<Image>();
            var prize = GachaManager.Instance.RunGacha();

            if (prize.name == "Baker")
            {
                if (sticker == true)
                    prize = nothing;
                sticker = true;
            }
            
            if (prize.name == "Frosto")
            {
                if (sticker == true)
                    prize = nothing;
                sticker = true;
            }
            
            if (prize.name == "Icecream")
            {
                if (sticker == true)
                    prize = nothing;
                sticker = true;
            }

            if (prize.name == "Inkneko")
            {
                if (sticker == true)
                    prize = nothing;
                sticker = true;
            }

            if (prize.name == "Facens")
            {
                if (sticker == true)
                    prize = nothing;
                sticker = true;
            }

            image.sprite = prize.image;
        }
    }

    private void Clear()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
