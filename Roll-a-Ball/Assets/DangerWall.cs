using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{
    // オブジェクトと接触した時に呼ばれるコールバック
    void OnCollisionEnter (Collision hit)
    {
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        if (count == 0) {
            return;
        }

        // 何かの処理
        if (hit.gameObject.CompareTag("Player")) {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

    }
}
