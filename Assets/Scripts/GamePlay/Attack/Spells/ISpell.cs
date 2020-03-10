using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpell
{
    SpellType SpellType { get; set; }
    void Cast();
}

public enum SpellType
{
    Ice,
    Fire,
    Air,
    Earth,
    Shadow
}