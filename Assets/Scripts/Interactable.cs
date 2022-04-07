using UnityEngine;

public abstract class Interactable : MonoBehaviour {
    private int _progressionTime;
    public abstract void OnActivation();
}
