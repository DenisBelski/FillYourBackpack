namespace FillYourBackpack
{
    public partial class Form1 : Form
    {
        private List<Item> items;

        public Form1()
        {
            InitializeComponent();
            AddItems();
            ShowItems(items);
        }

        private void AddItems()
        {
            items = new List<Item>();

            items.Add(new Item("Book", 1, 60));
            items.Add(new Item("Binoculars", 2, 500));
            items.Add(new Item("Aid kit", 4, 150));
            items.Add(new Item("Laptop", 2, 2000));
            items.Add(new Item("Charger", 1, 20));
        }

        private void ShowItems(List<Item> _items)
        {
            itemsListView.Items.Clear();

            foreach (Item i in _items)
            {
                itemsListView.Items.Add(new ListViewItem(new string[] { i.Name, i.Weight.ToString(), i.Price.ToString() }));
            }
        }

        private void ShowConditionsButton_Click(object sender, EventArgs e)
        {
            ShowItems(items);
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            Backpack backpack = new Backpack(Convert.ToDouble(weightTextBox.Text));

            backpack.MakeAllSets(items);

            List<Item> solvedTask = backpack.GetBestSet();

            if (solvedTask == null)
            {
                MessageBox.Show("There is no decision!");
            }
            else
            {
                itemsListView.Items.Clear();

                ShowItems(solvedTask);

                MessageBox.Show("The solution is shown in the table");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}