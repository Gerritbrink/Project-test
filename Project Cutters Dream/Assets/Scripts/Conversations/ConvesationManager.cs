using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ConvesationManager : MonoBehaviour
{
    public Convesation conversation;
    public int convoNum;
    public TMP_Text text;
    void Start ()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            convoNum += 1;
            text.text = conversation.convoText[convoNum];
        }
    }
}
