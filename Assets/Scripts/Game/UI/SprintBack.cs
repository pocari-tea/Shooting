using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintBack : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Movestick"))
        {
            Player.instance.sprint = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Movestick"))
        {
            Player.instance.sprint = false;
        }
    }
}
