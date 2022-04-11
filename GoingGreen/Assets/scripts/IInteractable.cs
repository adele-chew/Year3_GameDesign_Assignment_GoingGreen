using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    /// <summary>
    /// interface for all interactable objects (trash and recyclables)
    /// </summary>

    string GetDescription();
}