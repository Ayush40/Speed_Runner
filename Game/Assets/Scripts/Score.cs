using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text score;
    
    void Update()
    {
        score.text = Player.position.z.ToString("0");
    }
}
