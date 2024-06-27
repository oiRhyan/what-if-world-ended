using UnityEngine;
using System.Collections;

namespace DigitalRuby.BowAndArrow
{
    public class BowDemoScript : MonoBehaviour
    {
        public GameObject Ground;

        private void OnCollisionEnter2D(Collision2D coll)
        {
            Destroy(coll.gameObject);
        }

        private void Start()
        {

        }

        private void Update()
        {
            Ground.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, -1.0f, 0.0f));
        }
    }
}