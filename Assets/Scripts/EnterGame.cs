using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Cham Wall: " + other.name + " | tag = " + other.tag);

        if (other.CompareTag("Player") ||
            (other.attachedRigidbody != null && other.attachedRigidbody.CompareTag("Player")))
        {
            GameMenu.enabled = true;
        }
    }
}