using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soonStart : MonoBehaviour {
    public TrailRenderer tr;
    // Start is called before the first frame update
    void Start(){
        // Color re = new Color(1f, 0f, 0f, 1f);
        // Color or = new Color(1f, 0.6470588f, 0f, 1f);
        // Color y = new Color(1f, 1f, 0f, 1f);
        // Color g = new Color(0f, 1f, 0f, 1f);
        // Color b = new Color(0f, 1f, 1f, 1f);
        // Color p = new Color(1f, 0f, 1f, 1f);
        // Color pu = new Color(0.7630649f, 0.1822268f, 0.990566f, 1f);
        
        tr.enabled = false;
        // float alpha = 1.0f;
        // Gradient gradient = new Gradient();
        // gradient.SetKeys(
        //     new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.yellow, 1.0f) },
        //     new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        // );
    }

    // Update is called once per frame
    void Update() {
        StartCoroutine(test());
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    IEnumerator test(){
        yield return new WaitForSeconds(0.1f);
        tr.enabled = true;
    }
}
