using UnityEngine;

public class Slime
{
    public int Life;
    public string nombre;

    public Slime(int _life)
    {
        Life = _life;
    }

    public Slime(int _life, string _Nombre)
    {
        Life = _life;
        nombre = _Nombre;
    }


    public static Slime operator +(Slime s1, Slime s2)
    {
        return new Slime(s1.Life + s2.Life);
    }

    public void Getmensaje()
    {
        Debug.Log("se creo un slime de:" + nombre + "su vida es:" + Life);
    }
}
