 using System;
using System.Collections.Generic;
using System.Windows;

namespace Bingo_
{
    public partial class MainWindow : Window
    {
         
        private List<int> availableNumbers = new List<int>();

         
        public Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

             
            for (int i = 1; i <= 90; i++)
            {
                availableNumbers.Add(i);
            }

             
            ListBox1.ItemsSource = availableNumbers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (availableNumbers.Count == 0)
            {
                MessageBox.Show("All numbers have been picked!");
                return;
            }

            
            int index = random.Next(availableNumbers.Count);
            int pickedNumber = availableNumbers[index];
             
            Label.Content = pickedNumber.ToString();

            
            ListBox2.Items.Add(pickedNumber);

             
            availableNumbers.RemoveAt(index);
            ListBox1.Items.Refresh();  
        }
    }
}
