using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_crop : Triggers
{
    private Renderer m_renderer;
    private MaterialPropertyBlock prop_block;
    public void Start()
    {
        prop_block = new MaterialPropertyBlock();
    }

    public override void Interact()
    {
        foreach (Transform tile in this.transform)
        {
            m_renderer = tile.GetComponent<Renderer>();
            prop_block.SetColor("_Color", new Color(0.095f, 0.03f, 0.01f, 1));
            m_renderer.SetPropertyBlock(prop_block);
        }
        interacted = true;
    }
}
