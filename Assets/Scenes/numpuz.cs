using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class numpuz : MonoBehaviour
{
    public Text[] t;
    public Text w;
    public string[] s = { "1","2","3","4","5","6","7","","8"}; 
    public Button[] b;
    int cnt = 0;
    // Start is called before the first frame update

    public void OnChange()
    {
        SceneManager.LoadScene("SampleScene");
        print("bgfda");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Start()
    {
        oct();
    }
     
    
    void oct()
    {
        for (int ii = 0; ii < s.Length; ii++)
        {
            int r = Random.Range(0, s.Length);
            string temp = s[r];
            s[r] = s[ii];
            s[ii] = temp;
           
           
        }
        for (int j = 0; j < s.Length; j++)
        {
            t[j].text = s[j];

        }
    }
    public void move(int i)
    {
        if (i == 0)
        {

            if (t[1].text == "")
            {
                t[1].text = t[0].text;
                t[0].text = "";
            }
            else if (t[3].text == "")
            {
                t[3].text = t[0].text;
                t[0].text = "";
            }
            win();
        }
        else if (i == 1)
        {
            if (t[0].text == "")
            {
                t[0].text = t[1].text;
                t[1].text = "";
            }
            else if (t[4].text == "")
            {
                t[4].text = t[1].text;
                t[1].text = "";
            }
            else if (t[2].text == "")
            {
                t[2].text = t[1].text;
                t[1].text = "";
            }
            win();
        }
        else if (i == 2)
        {
            if (t[1].text == "")
            {
                t[1].text = t[2].text;
                t[2].text = "";
            }
            else if (t[5].text == "")
            {
                t[5].text = t[2].text;
                t[2].text = "";
            }
            win();
        }
        else if (i == 3)
        {
            if (t[0].text == "")
            {
                t[0].text = t[3].text;
                t[3].text = "";
            }
            else if (t[4].text == "")
            {
                t[4].text = t[3].text;
                t[3].text = "";
            }
            else if (t[6].text == "")
            {
                t[6].text = t[3].text;
                t[3].text = "";
            }
            win();
        }
        else if (i == 4)
        {
            if (t[1].text == "")
            {
                t[1].text = t[4].text;
                t[4].text = "";
            }
            else if (t[3].text == "")
            {
                t[3].text = t[4].text;
                t[4].text = "";
            }
            else if (t[7].text == "")
            {
                t[7].text = t[4].text;
                t[4].text = "";
            }
            else if (t[5].text == "")
            {
                t[5].text = t[4].text;
                t[4].text = "";
            }
            win();
        }
        else if (i == 5)
        {
            if (t[2].text == "")
            {
                t[2].text = t[5].text;
                t[5].text = "";
            }
            else if (t[4].text == "")
            {
                t[4].text = t[5].text;
                t[5].text = "";
            }
            else if (t[8].text == "")
            {
                t[8].text = t[5].text;
                t[5].text = "";
            }
            win();
        }
        else if (i == 6)
        {
            if (t[3].text == "")
            {
                t[3].text = t[6].text;
                t[6].text = "";
            }
            else if (t[7].text == "")
            {
                t[7].text = t[6].text;
                t[6].text = "";
            }
            win();
        }
        else if (i == 7)
        {
            if (t[6].text == "")
            {
                t[6].text = t[7].text;
                t[7].text = "";
            }
            else if (t[4].text == "")
            {
                t[4].text = t[7].text;
                t[7].text = "";
            }
            else if (t[8].text == "")
            {
                t[8].text = t[7].text;
                t[7].text = "";
            }
            win();
        }
        else if (i == 8)
        {
            if (t[5].text == "")
            {
                t[5].text = t[8].text;
                t[8].text = "";
            }
            else if (t[7].text == "")
            {
                t[7].text = t[8].text;
                t[8].text = "";
            }
            win();
        }
        else if (i == 9)
        {
            w.text = "";
            for (int ii = 0; ii < 9; ii++)
            {
                b[ii].interactable = true;
                t[ii].text = "";
                cnt = 0;

            }
            for (int ia = 0; ia < s.Length; ia++)
            {
                t[ia].text = s[ia];
            }
        }
    }
   
    void win()
    {
        if (t[0].text == "1" && t[1].text == "2" && t[2].text == "3" && t[3].text == "4" && t[4].text == "5" && t[5].text == "6" && t[6].text == "7" && t[7].text == "8" && t[8].text == "")
        {
            hide();
            w.text = "YOU WIN.."+w.ToString();

        }
    }

            void hide()
            {
                for (int i = 0; i < 9; i++)
                {
                    b[i].interactable = false;
                }
            }
        }


