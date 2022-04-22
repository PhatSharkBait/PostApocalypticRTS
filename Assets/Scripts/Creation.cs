using UnityEngine;

public abstract class Creation : MonoBehaviour {
    private int _health;
    private int _damageOutput;
    private int _range;
    private DamageType _damageType;
    private Player _owningPlayer;
    private DamageType[] _resistances;
    private DamageType[] _weaknesses;
    private Interactable[] _interactables;
    public abstract bool CanBeBuilt();
}
