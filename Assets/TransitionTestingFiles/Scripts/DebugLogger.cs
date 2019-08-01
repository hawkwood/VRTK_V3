using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class DebugLogger : MonoBehaviour {

    private string ParsedMessage(string message)
    {
        return message.Replace("%NAME%", gameObject.name);
    }

	public void Log (string message) {
        Debug.Log(ParsedMessage(message));
	}

    public void Warning(string message)
    {
        Debug.LogWarning(ParsedMessage(message));
    }

    public void SetTimeScale(float scale)
    {
        Time.timeScale = scale;
    }

    public void PauseEditor()
    {
#if UNITY_EDITOR
        EditorApplication.isPaused = true;
#endif
    }
}
