using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ScoreController : MonoBehaviour
{
    public int initialScore = 0;
    private int _currentScore = 0;

    private TextMeshProUGUI _scoreTextMeshPro;

    public int Score {
        get {
            return _currentScore;
        }

        set {
            if(value >= 0)
                _currentScore = value;

            Debug.Log("New Score: " + _currentScore);

            // Change Score Text
            _scoreTextMeshPro.text = "Pontos: " + _currentScore.ToString();
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _currentScore = initialScore;

        _scoreTextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            this.Score += 100;
        }
    }
}
