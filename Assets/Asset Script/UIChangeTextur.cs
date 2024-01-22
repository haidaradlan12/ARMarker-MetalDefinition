using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIChangeTextur : MonoBehaviour
{
    public Slider SliderTexture;
    public Material[] material;
    public int nilai1, nilai2, nilai3, nilai4;
    Renderer rend;
    [SerializeField] float nilai;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        SliderTexture = GameObject.Find("SliderTexture").GetComponent<Slider>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[x];
    }
    private void OnGUI()
    {
        nilai = GUI.VerticalSlider(new Rect(-77.0f, 2.0f, 20.0f, 160.0f), nilai, 200.0f, 1400.0f);
        if ((nilai>=0) && (nilai<nilai2))
        {
            x = 0;
        }
        else if ((nilai >= nilai2) && (nilai < nilai3))
        {
            x = 1;
        }
        else if ((nilai >= nilai3) && (nilai < nilai4))
        {
            x = 2;
        }
        else
        {
            x = 3;
        }
    }
    // Update is called once per frame
    void Update()
    {
        nilai = SliderTexture.value;
        if ((nilai >= 0) && (nilai < nilai2))
        {
            x = 0;
        }
        else if ((nilai >= nilai2) && (nilai < nilai3))
        {
            x = 1;
        }
        else if ((nilai >= nilai3) && (nilai < nilai4))
        {
            x = 2;
        }
        else
        {
            x = 3;
        }
        rend.sharedMaterial = material[x];
    }
}
