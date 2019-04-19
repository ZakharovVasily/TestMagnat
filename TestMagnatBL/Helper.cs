using System.Collections.Generic;
using System.Windows.Forms;

namespace TestMagnatBL
{
    public static class Helper
    {
        /// <summary>
        /// Рекурсия для показа категорий.
        /// </summary>
        public static TreeNode HelpedShowCategory(string currentNode, List<Category.Category> categoryList, TreeNode node)
        {
            foreach (Category.Category t in categoryList)
            {
                if (t.HeadNode == currentNode)
                {
                    var newNode = new TreeNode(t.NameNode);
                    node.Nodes.Add(newNode);

                    HelpedShowCategory(t.NameNode, categoryList, newNode);
                }
            }

            return node;
        }
    }
}
