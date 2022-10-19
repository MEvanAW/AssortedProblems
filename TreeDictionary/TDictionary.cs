namespace TreeDictionary
{
    public static class TDictionary
    {
        /// <summary>
        /// Checks whether a string exists in tree dictionary.
        /// </summary>
        /// <param name="tree">The root node of tree dictionary.</param>
        /// <param name="s">String to be searched.</param>
        /// <returns></returns>
        public static bool Exist(Tree tree, string s)
        {
            while (true)
            {
                if (Traverse(tree, s, "") == TrackStatus.Found)
                    return true;
                if (tree.Down != null)
                    tree = tree.Down;
                else
                    break;
            }
            return false;
        }

        private static TrackStatus Traverse(Tree tree, string target, string tracked)
        {
            tracked += tree.Value;
            if (!target.StartsWith(tracked))
                return TrackStatus.NotFound;
            else if (target == tracked)
                return TrackStatus.Found;
            TrackStatus rightDownResult;
            if (tree.Right != null)
            {
                TrackStatus rightResult = Traverse(tree.Right, target, tracked);
                if (rightResult != TrackStatus.Found)
                {
                    if (tree.Right.Down != null)
                    {
                        Tree downTree = tree.Right.Down;
                        while (true)
                        {
                            rightDownResult = Traverse(downTree, target, tracked);
                            if (rightDownResult == TrackStatus.Found)
                                return TrackStatus.Found;
                            if (downTree.Down != null)
                                downTree = downTree.Down;
                            else
                                break;
                        }
                    }
                    else
                        return TrackStatus.LeafReached;
                }
                else
                {
                    return TrackStatus.Found;
                }
            }
            else
                return TrackStatus.LeafReached;
            return rightDownResult;
        }

        internal enum TrackStatus: byte
        {
            LeafReached,
            NotFound,
            Found
        }
    }
}
