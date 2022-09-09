using UnityEngine;

namespace TemplateMethod.Scripts
{
    public class VK : Site
    {
        protected override void DrawHeader()
        {
            Debug.Log("VK.DrawHeader: ");
        }

        protected override void DrawBody()
        {
            Debug.Log("VK.DrawBody: ");
        }

        protected override void DrawFooter()
        {
            Debug.Log("VK.DrawFooter: ");
        }


        protected override void PrepareBody()
        {
            Debug.Log("VK.PrepareBody: ");
        }
    }
}