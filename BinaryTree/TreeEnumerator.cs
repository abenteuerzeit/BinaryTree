using System.Collections;

namespace BinaryTree
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        // hold a reference to the tree being enumerated
        private Tree<TItem> _currentData = null;

        //hold the value returned by the Current property
        private TItem _currentItem = default(TItem);

        // populated with the values extracted from the nodes in the tree
        private Queue<TItem> _enumData = null;

        public TreeEnumerator(Tree<TItem> data)
        {
            this._currentData = data;
        }

        TItem IEnumerator<TItem>.Current
            => this._enumData is not null
            ? this._currentItem
            : throw new InvalidOperationException("Use MoveNext before calling Current");

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            if (this._enumData == null)
            {
                this._enumData = new Queue<TItem>();
                Populate(this._enumData, this._currentData);
            }

            if (this._enumData.Count > 0)
            {
                this._currentItem = this._enumData.Dequeue();
                return true;
            }
            return false;
        }

        private void Populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if (tree.LeftTree is not null)
            {
                Populate(enumQueue, tree.LeftTree);
            }
            enumQueue.Enqueue(tree.NodeData);

            if (tree.RightTree is not null)
            {
                Populate(enumQueue, tree.RightTree);
            }
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
