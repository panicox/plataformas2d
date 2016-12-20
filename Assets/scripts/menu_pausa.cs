using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class menu_pausa : MonoBehaviour
{
    Animator anim;
    private bool MenuPausa = false;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (MenuPausa)
            {
                continuar();
            }
            else
            {
                pausa();
            }
        }
    }

    public void pausa()
    {
        MenuPausa = true;
        Time.timeScale = 0;
        anim.SetBool("opciones", false);
        anim.SetBool("pausa", true);
    }

    public void salir()
    {
        Application.Quit();
    }

    public void opciones()
    {
        anim.SetBool("opciones", true);
        anim.SetBool("pausa", true);
    }

    public void continuar()
    {
        MenuPausa = false;
        Time.timeScale = 1;
        anim.SetBool("opciones", false);
        anim.SetBool("pausa", false);
    }
}