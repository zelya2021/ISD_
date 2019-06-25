using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace Lesson4_ADOnet
{
    public partial class Form1 : Form
    {
        int selectedrow;
        DataContext dataContext;
        public Form1()
        {
            InitializeComponent();
            Show_table();
        }
        private void Show_table()
        {
            dataContext = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Lesson4_ADOnet\Lesson4_ADOnet\Car_Showroom.mdf;Integrated Security=True");
            Table<Car> cars = dataContext.GetTable<Car>();
            foreach (var item in cars)
            {
                DG_Cars.Rows.Add(item.Id, item.Mark, item.Price);
            }
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            dataContext = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Lesson4_ADOnet\Lesson4_ADOnet\Car_Showroom.mdf;Integrated Security=True");
            var Car= dataContext.GetTable<Car>();
            
            Car.InsertOnSubmit(new Car
            {
                Mark = tb_Mark.Text,
                Price= Convert.ToInt32(tb_Price.Text)
            });
            dataContext.SubmitChanges();
            DG_Cars.Rows.Clear();
            Show_table();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            dataContext = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Lesson4_ADOnet\Lesson4_ADOnet\Car_Showroom.mdf;Integrated Security=True");
            var tableCars = dataContext.GetTable<Car>();
            var cars = tableCars.ToList();


            //var findCar = cars.FirstOrDefault(car => car.Id == selectedrow);
            var findCar = cars.FirstOrDefault(car => car.Id == Convert.ToInt32(Id.Text));
            findCar.Mark = tb_Mark.Text;
            findCar.Price = Convert.ToInt32(tb_Price.Text);
            dataContext.SubmitChanges();
            DG_Cars.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            dataContext = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Lesson4_ADOnet\Lesson4_ADOnet\Car_Showroom.mdf;Integrated Security=True");
            var tableCars = dataContext.GetTable<Car>();
            var cars = tableCars.ToList();
            var deleteCar = cars.FirstOrDefault(car => car.Id == Convert.ToInt32(Id.Text));
            tableCars.DeleteOnSubmit(deleteCar);
            dataContext.SubmitChanges();
            DG_Cars.Rows.Clear();
            Show_table();
        }

        private void DG_Cars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectedrow = ["column_Id", DG_Cars.CurrentRow.Index].Value.ToString();
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Cars.Rows[selectedrow];
            Id.Text = row.Cells[0].Value.ToString();
            tb_Mark.Text = row.Cells[1].Value.ToString();
            tb_Price.Text = row.Cells[2].Value.ToString();
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }
    }
}
