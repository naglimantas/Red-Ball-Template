using UnityEngine;
using UnityEngine.U2D;

public class Secret : MonoBehaviour
{
	SpriteShapeRenderer renderer;
	bool visible;
	float a = 1f;

	void Start()
	{
		renderer = GetComponent<SpriteShapeRenderer>();
	}

	void Update()
	{
		if (visible)
		{
			a -= Time.deltaTime;
		}
		else
		{
			a += Time.deltaTime;
		}

		renderer.color = new Color(1, 1, 1, a);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		visible = true;
	}
}