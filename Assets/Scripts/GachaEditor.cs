using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class GachaEditor : MonoBehaviour
{
    public GameObject gachaConfigPrefab;
    public Transform configParent;
    
    public void Start()
    {
        Clear();

        for (int i = 0; i < GachaManager.Instance.items.Count; i++)
        {
            var gb = Instantiate(gachaConfigPrefab, configParent);
            var gachaConfig = gb.GetComponent<GachaConfig>();
            gachaConfig.SetIndex(i);
            var item = GachaManager.Instance.items[i];
            gachaConfig.SetInfo(item.prize.name, item.percentage);
        }
    }

    private void Clear()
    {
        for (int i = 0; i < configParent.childCount; i++)
        {
            Destroy(configParent.GetChild(i).gameObject);
        }
    }
}
