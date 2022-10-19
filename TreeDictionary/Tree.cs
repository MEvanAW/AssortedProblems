namespace TreeDictionary
{
    /// <summary>
    /// Tree of characters.
    /// </summary>
    public class Tree
    {
        public Tree? Right { get; set; }
        public char Value { get; set; }
        public Tree? Down { get; set; }
        /// <summary>
        /// Constructor of Tree
        /// </summary>
        /// <param name="right">Tree to the right of this tree.</param>
        /// <param name="value">The character of this tree.</param>
        /// <param name="down">Tree to the down of this tree.</param>
        public Tree(Tree? right, char value, Tree? down)
        {
            Right = right;
            Value = value;
            Down = down;
        }
    }
}