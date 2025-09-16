using UnityEngine;

 public enum Emotion
 {
    None,
    Happy,
    Angry,
    Sad,
    Scared,
    Anxius
 }
public class NPC
{
    private string npcName;
    private Emotion emotion;
    private string dialog;

    public NPC(string _npcName, Emotion _emotion, string _dialog)
    {
        npcName = _npcName;
        emotion = _emotion;
        dialog = _dialog;

    }
    public void Talk()
    {
        Debug.Log("Hola me llamo " + npcName + "Me siento ... " + emotion + " Queria decirte que " + dialog);
    }
    public void Talk(string newNpcName)
    {
        npcName = newNpcName;
        Debug.Log("Hola me llamo " + npcName + "Me siento ... " + emotion + " Queria decirte que " + dialog);
    }
    public void Talk(string newNpcName, Emotion newEmotion)
    {
        npcName = newNpcName;
        emotion = newEmotion;

        Debug.Log("Hola me llamo " + npcName + "Me siento ... " + emotion + " Queria decirte que " + dialog);
    }
    public void Talk(string newNpcName, Emotion newEmotion, string newDialog)
    {
        npcName = newNpcName;
        emotion = newEmotion;
        dialog = newDialog;

        Debug.Log("Hola me llamo " + npcName + "Me siento ... " + emotion + " Queria decirte que " + dialog);
    }

    public string NpcName => npcName;
    public Emotion Emotion => emotion;
    public string Dialog => dialog;

}
