using JetBrains.Annotations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Slime Slime1;
    public Slime Slime2;

    void Start()
    {
        Slime1 = new Slime(10,"slime de fuego");
        Slime2 = new Slime(10, "slime de hielo");

        Slime1.Getmensaje();
        Slime2.Getmensaje();
    }
 
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {

          Slime slime3 = Slime1 + Slime2;
            slime3.Getmensaje();
        }

    }
}
