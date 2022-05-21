using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonText : MonoBehaviour
{
    public TexMeshProUGUI ;

    public void update(){
        if (input.GetKeyDown("z")){
            SetText("Fishing!");
        }
    }

    public void SetText(string text)
    {

        Textfield.text = text; 
    }

}
