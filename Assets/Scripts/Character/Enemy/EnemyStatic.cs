using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
namespace AI
{
    public class EnemyStatic : Enemy
    {
        // Start is called before the first frame update
        void Start()
        {
            DisableRagdoll();
        }

        // Update is called once per frame
        void Update()
        {
        
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(TagUtils.Bullet) ||
                collision.gameObject.CompareTag(TagUtils.SmasherObstacle))
            {
                DeathUsingRagdoll();
            }
        }
    }

}
