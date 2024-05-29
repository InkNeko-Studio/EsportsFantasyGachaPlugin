using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class GachaConfig : MonoBehaviour
    {
        public int index;

        public TMP_Text nameText;
        public TMP_InputField inputField;
        
        public void SetIndex(int i)
        {
            index = i;
        }

        public void SetInfo(string name, float percentage)
        {
            nameText.text = name;
            inputField.text = percentage + "";
        }

        public void OnChangeValue()
        {
            GachaManager.Instance.items[index].percentage = float.Parse(inputField.text);
        }
    }
}