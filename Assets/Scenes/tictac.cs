using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class tictac : MonoBehaviour
{
   
    public Text[] b;
    public Button[] d;
    public Text l,rudra,xx,oo;
    int cnt = 0,xm=0,om=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void tic(int i)
    {
       
            if (cnt % 2 == 0)
            {
                b[i].text = "X";
                d[i].interactable = false;
                cnt++;
                rudra.text = "Move 0 "+rudra.ToString();
                win();
            }
            else
            {
                b[i].text = "0";
                d[i].interactable = false;
                cnt++;
            rudra.text = "Move X " + rudra.ToString();
            win();
            }
        
    }
    public void res()
    {
        tru();  
        clean();
        l.text = "";
        rudra.text = "";
    }
    void win()
    {
        if (b[0].text == "X" && b[1].text == "X" && b[2].text == "X" || b[3].text == "X" && b[4].text == "X" && b[5].text == "X" || b[6].text == "X" && b[7].text == "X" && b[8].text == "X" || b[0].text == "X" && b[3].text == "X" && b[6].text == "X" || b[1].text == "X" && b[4].text == "X" && b[7].text == "X" || b[2].text == "X" && b[5].text == "X" && b[8].text == "X" || b[0].text == "X" && b[4].text == "X" && b[8].text == "X" || b[2].text == "X" && b[4].text == "X" && b[6].text == "X")
        {
            l.text = "X is win..." + l.ToString();
            fal();
        
            xm++;

        }
        else if (b[0].text == "0" && b[1].text == "0" && b[2].text == "0" || b[3].text == "0" && b[4].text == "0" && b[5].text == "0" || b[6].text == "0" && b[7].text == "0" && b[8].text == "0" || b[0].text == "0" && b[3].text == "0" && b[6].text == "0" || b[1].text == "0" && b[4].text == "0" && b[7].text == "0" || b[2].text == "0" && b[5].text == "0" && b[8].text == "0" || b[0].text == "0" && b[4].text == "0" && b[8].text == "0" || b[2].text == "0" && b[4].text == "0" && b[6].text == "0")
        {
            l.text = "0 is win..."+l.ToString();
            fal();
            om++;
        }
    }
    void kingo()
    {
        if (cnt == 0)
        {
            b[0].text = "0";
            cnt++;
        }
        else if (b[0].text == "X" && b[1].text == "X" && b[2].text == "X" || b[3].text == "X" && b[4].text == "X" && b[5].text == "X" || b[6].text == "X" && b[7].text == "X" && b[8].text == "X" || b[0].text == "X" && b[3].text == "X" && b[6].text == "X" || b[1].text == "X" && b[4].text == "X" && b[7].text == "X" || b[2].text == "X" && b[5].text == "X" && b[8].text == "X" || b[0].text == "X" && b[4].text == "X" && b[8].text == "X" || b[2].text == "X" && b[4].text == "X" && b[6].text == "X")
        {
            

        }
        //if()
        /* else if (b[0].text == "X" && b[1].text == "X")
         {
             b[2].text = "0";
         }
         else if (b[3].text == "x" && b[4].text == "X")
         { 

         }*/
    }
    public void OnChange()
    {
        SceneManager.LoadScene("num");
    }
    void tru()
    {
        d[0].interactable = true;
        d[1].interactable = true;
        d[2].interactable = true;
        d[3].interactable = true;
        d[4].interactable = true;
        d[5].interactable = true;
        d[6].interactable = true;
        d[7].interactable = true;
        d[8].interactable = true;
       
    }
    void clean()
    {
        for (int i = 0; i <=8; i++)
        {
            b[i].text = "";
        }
    }
    void fal()
    {
        d[0].interactable = false;
        d[1].interactable = false;
        d[2].interactable = false;
        d[3].interactable = false;
        d[4].interactable = false;
        d[5].interactable = false;
        d[6].interactable = false;
        d[7].interactable = false;
        d[8].interactable = false;
    }
}
