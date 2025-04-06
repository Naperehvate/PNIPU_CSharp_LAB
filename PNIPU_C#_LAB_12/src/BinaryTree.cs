using ClassLibrary;

namespace PNIPU_C__LAB_12
{
    internal class TreeNode
    {
        public Person Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(Person data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    internal class BinaryTree
    {
        private TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        // Метод для создания балансированного дерева
        public TreeNode CreateBalancedTree(Person[] data, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(data[mid]);

            node.Left = CreateBalancedTree(data, start, mid - 1);
            node.Right = CreateBalancedTree(data, mid + 1, end);

            if (start == 0 && end == data.Length - 1)
                root = node; // Устанавливаем корень дерева

            return node;
        }

        // Метод для печати дерева (инфиксный обход)
        public void PrintTree(TreeNode node)
        {
            if (node == null)
            {
                Console.WriteLine("Дерево пустое.");
                return;
            }

            if (node != null)
            {
                PrintTree(node.Left);
                node.Data.Show();
                PrintTree(node.Right);
            }
        }

        // Метод для подсчета листьев в дереве
        public int CountLeaves(TreeNode node)
        {
            if (node == null)
                return 0;
            if (node.Left == null && node.Right == null)
                return 1;
            return CountLeaves(node.Left) + CountLeaves(node.Right);
        }

        // Метод для преобразования дерева в дерево поиска
        public void ConvertToSearchTree(ref TreeNode root)
        {
            if (root == null)
                return;

            List<Person> sortedList = new List<Person>();
            InOrderTraversal(root, sortedList);
            sortedList.Sort((a, b) => a.Age.CompareTo(b.Age));
            root = BuildSearchTree(sortedList, 0, sortedList.Count - 1);
        }

        // Вспомогательный метод для инфиксного обхода
        private void InOrderTraversal(TreeNode node, List<Person> list)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, list);
                list.Add(node.Data);
                InOrderTraversal(node.Right, list);
            }
        }

        // Вспомогательный метод для построения дерева поиска
        private TreeNode BuildSearchTree(List<Person> list, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(list[mid]);

            node.Left = BuildSearchTree(list, start, mid - 1);
            node.Right = BuildSearchTree(list, mid + 1, end);

            return node;
        }

        // Метод для удаления дерева
        public void ClearTree(TreeNode node)
        {
            if (node == null)
                return;

            // Рекурсивно удаляем левое и правое поддеревья
            ClearTree(node.Left);
            ClearTree(node.Right);

            // Обнуляем ссылки у текущего узла
            node.Left = null;
            node.Right = null;
        }

        // Метод для вызова очистки дерева
        public void ClearTree(ref TreeNode root)
        {
            ClearTree(root);
            root = null; // Удаляем корневой узел
        }
    }
}