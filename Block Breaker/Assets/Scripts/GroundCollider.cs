using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundCollider : MonoBehaviour {

    public LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadLevel("Win screen");
    }


}
