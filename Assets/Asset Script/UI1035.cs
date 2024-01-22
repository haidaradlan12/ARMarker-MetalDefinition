using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI1035 : MonoBehaviour
{
    public Slider Slider1006;
    [SerializeField] float nilai;
    public GameObject Tanda1, Tanda2;
    public GameObject FCC135, FCC235, BCT135;
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
        if ((nilai > 900) && (kotak == true))
        {
            FCC135.SetActive(false);
            FCC235.SetActive(false);
            BCT135.SetActive(true);
            Tanda1.SetActive(true);
            Tanda2.SetActive(false);
        }
        else if ((nilai <= 900) && (kotak == true))
        {           
            
                FCC135.SetActive(true);
                FCC235.SetActive(true);
                BCT135.SetActive(false);
            Tanda2.SetActive(true);
            Tanda1.SetActive(false);
        }
        else
        {
            FCC235.SetActive(false);
            FCC135.SetActive(false);
            BCT135.SetActive(false);

            Tanda1.SetActive(false);
            Tanda2.SetActive(false);
        }
        
    }
}
