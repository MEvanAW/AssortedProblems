using System.Text;

namespace TreeDictionary
{
    public static class TDictionary
    {
        internal enum TrackStatus : byte
        {
            LeafReached,
            NotFound,
            Found
        }

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

        public static string PrintTree(Tree tree)
        {
            StringBuilder sb = new("");
            while (true)
            {
                var trackedWords = new Dictionary<int, List<string>>();
                PrintTraversal(tree, trackedWords, "", 0, 0, true);
                bool firstLine = true;
                int count1 = 0;
                int count2 = trackedWords.Count;
                foreach (KeyValuePair<int, List<string>> kvp in trackedWords)
                {
                    if (!firstLine)
                    {
                        if (tree.Down != null)
                            sb.Append('|');
                        else
                            sb.Append(' ');
                        if (kvp.Key > 0)
                            sb.Append(new string(' ', kvp.Key * 4 - 1));
                        sb.Append('|');
                        sb.AppendLine();
                        if (tree.Down != null)
                            sb.Append('|');
                        else
                            sb.Append(' ');
                    }
                    if (kvp.Key > 0)
                        sb.Append(new string(' ', kvp.Key * 4 - 1));
                    sb.AppendJoin(" - ", kvp.Value[0].ToCharArray());
                    count1++;
                    if (tree.Down == null && count1 == count2)
                        break;
                    sb.AppendLine();
                    firstLine = false;
                }
                if (tree.Down != null)
                {
                    sb.Append('|');
                    sb.AppendLine();
                    tree = tree.Down;
                }
                else
                {
                    break;
                }
            }
            return sb.ToString();
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

        public static void PrintTraversal(Tree tree, Dictionary<int, List<string>> trackedWords, string trackedWord, int xStart, int xNow, bool wordStart)
        {
            trackedWord += tree.Value;
            if (tree.Right != null)
            {
                PrintTraversal(tree.Right, trackedWords, trackedWord, xStart, xNow + 1, false);
            }
            else if (tree.Down == null)
            {
                try
                {
                    trackedWords.Add(xStart, new List<string>() { trackedWord });
                }
                catch
                {
                    trackedWords[xStart].Add(trackedWord);
                }
            }
            if (tree.Down != null && !wordStart)
            {
                PrintTraversal(tree.Down, trackedWords, "", xNow, xNow, false);
            }
        }
    }
}
