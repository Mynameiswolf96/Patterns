using UnityEngine;

namespace TemplateMethod.Scripts
{
    public class GB : Site
    {
        protected override void DrawHeader()
        {
            Debug.Log("GB.DrawHeader: ");
        }

        protected override void DrawBody()
        {
            Debug.Log("GB.DrawBody: ");
        }

        protected override void DrawFooter()
        {
            Debug.Log("GB.DrawFooter: ");
        }


        protected override void PrepareBody()
        {
            Debug.Log("GB.PrepareBody: ");
        }
    }
}