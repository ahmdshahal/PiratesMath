using UnityEngine;

public class JawabSoal : MonoBehaviour
{
    public GameObject kosong, charabenar, charasalah, sekat;
    public bool benar;
    
    private void OnMouseUp()
    {
        kosong.SetActive(true);

        if (benar)
        {
            charabenar.SetActive(false);
            charabenar.SetActive(true);
        }
        else
        {
            charasalah.SetActive(false);
            charasalah.SetActive(true);
        }

        Destroy(gameObject);
    }
}
