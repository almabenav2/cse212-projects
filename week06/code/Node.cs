public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if  (value == Data) {
            return;
        }
        
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) {
        return true;
        }
        else if (value < Data && Left != null) {
            // The value  can be in the left subtree
            return Left.Contains(value);
        }
        else if (value > Data && Right != null) {
            // The value  can be in the right subtree
            return Right.Contains(value);
        }
        else {
            // The value  does not exist in the tree
            return false;
        }
        
    }

    public int GetHeight() {
        // TODO Start Problem 4
        // If node is null, height is 0 
        if (this is null) {
            return 0;
        }

        // Calculate  the height of left and right subtrees recursively
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // The  height of a tree is one plus the maximum height
        return 1 + Math.Max(leftHeight, rightHeight);
        }
}