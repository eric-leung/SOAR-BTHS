using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public stockLq stock;
    public tubeLq liq1;
    public tubeLq liq2;

    public double input1;
    public double input2;
    public double molarity;

    public int concNum;

    public GameObject check1;
    public GameObject check2;

    [SerializeField]
    private Text concTex;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1600, 900, true);

        SpriteRenderer beakerFill = stock.GetComponent<SpriteRenderer>();
        beakerFill.color = new Color(256, 256, 256);

        SpriteRenderer tub1Fill = liq1.GetComponent<SpriteRenderer>();
        tub1Fill.color = new Color(256, 256, 256);

        SpriteRenderer tub2Fill = liq2.GetComponent<SpriteRenderer>();
        tub2Fill.color = new Color(256, 256, 256);

        check1.SetActive(false);
        check2.SetActive(false);

        concTex.text = "0 M";
        concNum = 0;
    }

    public void UserSelectsTwoM()
    {
        SpriteRenderer beakerFill = stock.GetComponent<SpriteRenderer>();
        beakerFill.color = new Color(255f/255f, 85f/255f, 85f/255f);


        concTex.text = "2 M";
        concNum = 2;
    }

    public void UserSelectsThreeM()
    {
        SpriteRenderer beakerFill = stock.GetComponent<SpriteRenderer>();
        beakerFill.color = new Color(255f/255f, 0, 0);

        concTex.text = "3 M";
        concNum = 3;
    }

    public void GetInput1(string guess)
    {
        input1 = double.Parse(guess);

        if (concNum == 2)
        {
            if (input1 == 50)
            {
                check1.SetActive(true);
            }
            else
            {
                check1.SetActive(false);
            }
        }
        else if (concNum == 3)
        {
            if (input1 == 33)
            {
                check1.SetActive(true);
            }
            else
            {
                check1.SetActive(false);
            }
        }
        molarity = (-85 * (concNum * (input1 / 1000)) / (0.1)) + 255;
        float colorNum = (float)molarity / 255;

        SpriteRenderer tub1Fill = liq1.GetComponent<SpriteRenderer>();
        tub1Fill.color = new Color(255f / 255f, colorNum, colorNum);
        //tub1Fill.color = new Color(255f/255f, 170/255f, 170f/255f);
    }

    public void GetInput2(string guess)
    {
        input2 = double.Parse(guess);

        if (concNum == 2)
        {
            if (input2 == 25)
            {
                check2.SetActive(true);
            }
            else
            {
                check2.SetActive(false);
            }
        }
        else if (concNum == 3)
        {
            if (input2 == 17)
            {
                check2.SetActive(true);
            }
            else
            {
                check2.SetActive(false);
            }
        }
        molarity = (-85 * (concNum * (input2 / 1000)) / (0.1)) + 255;
        float colorNum = (float)molarity / 255;

        SpriteRenderer tub2Fill = liq2.GetComponent<SpriteRenderer>();
        tub2Fill.color = new Color(255f/255f, colorNum, colorNum);
        //tub2Fill.color = new Color(255f/255f, 213f/255f, 213f/255f);
    }
}
