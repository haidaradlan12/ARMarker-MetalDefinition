using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateKanan : MonoBehaviour
{
    public Slider RotateSliderY;
    public Slider RotateSliderX;

    [SerializeField] float currentRotationY = 180.0f;
    [SerializeField] float currentRotationX = -90.0f;
    // Start is called before the first frame update
    void Start()
    {
        RotateSliderY = GameObject.Find("RotateS1 Y").GetComponent<Slider>();
        RotateSliderX = GameObject.Find("RotateS1 X").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(RotateSliderX.value, 0.0f, RotateSliderY.value);
    }

    private void OnGUI()
    {
        currentRotationY = GUI.HorizontalSlider(new Rect(410.6f, -299.4f, 350.0f, 50.0f), currentRotationY, 180.0f, 540.0f);
        currentRotationX = GUI.HorizontalSlider(new Rect(410.6f, -391.0f, 350.0f, 50.0f), currentRotationX, -90.0f, 270.0f);
        transform.Rotate(new Vector3(currentRotationX, 0.0f, currentRotationY));
    }

    public void AdjustAngle(float newAngle)
    {
        
    }
}
