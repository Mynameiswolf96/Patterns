using UnityEngine;

namespace TemplateMethod.Scripts
{
    public class TemplateMethodExample : MonoBehaviour
    {
        [ContextMenu("Test Template Method Draw")]
        private void TestTemplateMethodDraw()
        {
            Site vk = new VK();
            vk.Draw();

            Site gb = new GB();
            gb.Draw();
        }

        [ContextMenu("Test Template Method Prepare")]
        private void TestTemplateMethodPrepare()
        {
            Site vk = new VK();
            vk.Prepare();

            Site gb = new GB();
            gb.Prepare();
        }
    }
}