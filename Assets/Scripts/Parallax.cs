using UnityEngine;

public class Parallax : MonoBehaviour
{
    MeshRenderer _meshRenderer;
    public float animationSpeed = 1f;

    private void Awake() => _meshRenderer = GetComponent<MeshRenderer>();

    private void Update() => MoveBackground();

    public void MoveBackground() 
        => _meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
}
