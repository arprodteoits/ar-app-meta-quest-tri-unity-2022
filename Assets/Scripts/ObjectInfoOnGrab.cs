using UnityEngine;
using Oculus.Interaction;

public class ObjectInfoOnGrab : MonoBehaviour
{
    public GameObject infoCanvas;

    private void Start()
    {
        infoCanvas.SetActive(false);
    }

    // Dipanggil saat object di-grab
    public void OnGrab()
    {
        infoCanvas.SetActive(true);
    }

    // Dipanggil saat dilepas
    public void OnRelease()
    {
        infoCanvas.SetActive(false);
    }
}
