using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIS1006: MonoBehaviour
{
    public Slider Slider1006;
    [SerializeField] float nilai;
    public GameObject BCC1, BCC2, FCC3, FCC4, BCT2;
    public GameObject Tanda1, Tanda2, Tanda3;
    public GameObject B_Satu, B_Sel, kotak;
    // Start is called before the first frame update
    void Start()
    {
        Slider1006 = GameObject.Find("SliderTexture").GetComponent<Slider>();
    }
    private void OnGUI()
    {
        nilai = GUI.VerticalSlider(new Rect(-77.0f, 2.0f, 20.0f, 160.0f), nilai, 200.0f, 1400.0f);
    }
    // Update is called once per frame
    void Update()
    {
        nilai = Slider1006.value;
        if ((nilai < 850) && (kotak == true))
        {
            
                BCC1.SetActive(true);
                BCC2.SetActive(true);
                FCC3.SetActive(false);
                FCC4.SetActive(false);
                BCT2.SetActive(false);
            Tanda1.SetActive(true);
            Tanda2.SetActive(false);
            Tanda3.SetActive(false);
        }
        else if ((nilai >= 850) && (nilai < 900) && (kotak == true))
        {
            
                FCC3.SetActive(true);
                FCC4.SetActive(true);
                BCC1.SetActive(false);
                BCC2.SetActive(false);
                BCT2.SetActive(false);

            Tanda2.SetActive(true);
            Tanda1.SetActive(false);
            Tanda3.SetActive(false);
        }
        else if ((nilai >= 900) && (kotak == true))
        {
            
            BCT2.SetActive(true);
            BCC1.SetActive(false);
            BCC2.SetActive(false);
            FCC3.SetActive(false);
            FCC4.SetActive(false);

            Tanda3.SetActive(true);
            Tanda2.SetActive(false);
            Tanda1.SetActive(false);
        }
        else
        {
            BCT2.SetActive(false);
            BCC1.SetActive(false);
            BCC2.SetActive(false);
            FCC3.SetActive(false);
            FCC4.SetActive(false);

            Tanda1.SetActive(false);
            Tanda2.SetActive(false);
            Tanda3.SetActive(false);
        }
    }
}
