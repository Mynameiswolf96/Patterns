using UnityEngine;

namespace TemplateMethod.Scripts
{
    public abstract class Site
    {
        public void Draw()
        {
            DrawHeader();
            DrawBody();
            DrawFooter();
        }


        protected abstract void DrawHeader();
        protected abstract void DrawBody();
        protected abstract void DrawFooter();


        public void Prepare()
        {
            PrepareHeader();
            PrepareBody();
            PrepareFooter();
        }

        private void PrepareHeader()
        {
            Debug.Log("Site.PrepareHeader: ");
        }

        protected abstract void PrepareBody();

        private void PrepareFooter()
        {
            Debug.Log("Site.PrepareFooter: ");
        }
    }
}