using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckNormis : MonoBehaviour
{
    public TextMeshProUGUI jokeText;

    public void NewJoke()
    {
        Joke j = APIHelper.GetNewJoke();
        jokeText.text = j.value;

    }
}
