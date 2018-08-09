using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.TreeDepth
{
    public static class TreeDepthHelper
    {
        public static int GetTreeDepth(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = GetTreeDepth(root.LeftChild);
            int right = GetTreeDepth(root.RightChild);

            return left >= right ? left + 1 : right + 1;
        }
    }
}
