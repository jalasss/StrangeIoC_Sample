
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class CubeView : View {
    private Text scoreText;

    public void Init() {
        scoreText = GetComponentInChildren<Text>();

    }

    private void Update()
    {
        transform.Translate(new Vector3(UnityEngine.Random.Range(-1,2), Random.Range(-1, 2), Random.Range(-1, 2))*.2f);
    }
    private void OnMouseDown()
    {
        Debug.Log("onMouseDown");
    }

    public void updateScore(int score) {
        scoreText.text = score.ToString();
    }

 
}
