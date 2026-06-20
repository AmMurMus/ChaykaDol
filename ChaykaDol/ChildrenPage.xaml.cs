// Этот метод удаляет ребёнка из базы данных
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;
using ChaykaDol.Models;

namespace ChaykaDol
{
    public partial class ChildrenPage : Page
    {
        public ChildrenPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgChildren.ItemsSource = DBContext.GetContext().Children
                .Include(c => c.Group)
                .ToList();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = txtSearch.Text.ToLower();
            dgChildren.ItemsSource = DBContext.GetContext().Children
                .Include(c => c.Group)
                .Where(c => c.FullName.ToLower().Contains(search))
                .ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавление будет реализовано позже");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgChildren.SelectedItem is Child selected)
            {
                if (MessageBox.Show($"Удалить {selected.FullName}?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    DBContext.GetContext().Children.Remove(selected);
                    DBContext.GetContext().SaveChanges();
                    LoadData();
                }
            }
            else MessageBox.Show("Выберите ребёнка");
        }
    }
}
