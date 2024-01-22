using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuBackground1, MenuButton1, MenuLogo, MenuReferensi;
    public RectTransform MenuBackgroundProfil, MenuBackgroundMateri, MenuProfil, MenuPetunjuk, MenuMateri, MenuMateri1, MenuMateri2, MenuMateri3, MenuMateri4, MenuMateri5, MenuPengaturan, MenuButton, MenuPindai;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -4500), 1.0f);
    }
    public void MenuReferensiButton()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -4500), 1.0f);
    }
    public void MenuMulaiButton()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 126), 1.0f);
    }
    public void MenuPetunjukButton()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 126), 1.0f);
    }
    public void MenuProfilButton()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 126), 1.0f);
    }
    public void MenuMateriButton()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 126), 1.0f);
    }
    public void MenuPengaturanButton()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 126), 1.0f);
    }
    public void MenuKembaliButton()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        //pertama
        MenuBackground1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuLogo.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuReferensi.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        //kedua
        MenuBackgroundProfil.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuBackgroundMateri.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuProfil.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri1.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri2.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri3.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri4.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuMateri5.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPengaturan.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 4500), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -4500), 1.0f);
    }
    public void MenuPindaiButton()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        MenuBackground1.DOAnchorPos(new Vector2(0, -4500), 1.0f);
        MenuPindai.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
