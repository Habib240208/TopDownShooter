using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILLALLZombies : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
            KillZombiesPerenstOnScene();
    }
    public void KillZombiesPerenstOnScene()
    {
        GameObject[] listOfZombies;
        listOfZombies = GameObject.FindGameObjectsWithTag("Zombie");
        foreach(GameObject zombie in listOfZombies)
        {
            Destroy(zombie);
        }
    }
}
