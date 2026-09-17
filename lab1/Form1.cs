namespace lab1
{
    public partial class Form1 : Form
    {
        private DBManager dataManager;
        private DataGridView dgvCategory, dgvProduct;

        public Form1()
        {
            InitializeComponent();
            dataManager = new DBManager();
            dataManager.InitializeDatabase();
        }

        private void btnInsertCategory_click(object sender, EventArgs e)
        {
            try
            {
                dataManager.InsertCategory(int.Parse(textCategoryId.Text), textCategoryName.Text, textCategoryDescription.Text);
                MessageBox.Show("Категорію додано.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnInsertProduct_click(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(textProductPrice.Text, System.Globalization.CultureInfo.InvariantCulture);

                dataManager.InsertProduct(int.Parse(textProductId.Text), textProductName.Text, price, textProductUnit.Text, int.Parse(textProductCategoryId.Text));
                MessageBox.Show("Товар додано.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnUpdateCategoryId_click(object sender, EventArgs e)
        {
            try
            {
                dataManager.UpdateCategoryId(int.Parse(textOldCategoryId.Text), int.Parse(textNewCategoryId.Text));
                MessageBox.Show("ID оновлено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnDeleteCategory_click(object sender, EventArgs e)
        {
            try
            {
                dataManager.DeleteCategory(int.Parse(textDeleteCategory.Text));
                MessageBox.Show("Категорію видалено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnUpdatedgv_click(object sender, EventArgs e)
        {
            dgvCategory.DataSource = dataManager.GetCategories();
            dgvProduct.DataSource = dataManager.GetProducts();
        }

        
    }
}
