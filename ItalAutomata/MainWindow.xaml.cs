using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace ItalAutomata
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int balance = 0;
        int inserted = 0;
        int cola = 0;
        int pepsi = 0;
        int fanta = 0;
        int sevenup = 0;
        int sprite = 0;

        private void Refill_Clicked(object sender, RoutedEventArgs e)
        {
            cola = 15;
            pepsi = 15;
            fanta = 15;
            sevenup = 15;
            sprite = 15;

            tbInvCola.Text = "Coca Cola: " + cola + "db";
            tbInvPepsi.Text = "Pepsi: " + pepsi + "db";
            tbInvFanta.Text = "Fanta: " + fanta + "db";
            tbInv7up.Text = "7up: " + sevenup + "db";
            tbInvSprite.Text = "Sprite: " + sprite + "db";

            emptycola.Visibility = System.Windows.Visibility.Hidden;
            emptypepsi.Visibility = System.Windows.Visibility.Hidden;
            emptyfanta.Visibility = System.Windows.Visibility.Hidden;
            empty7up.Visibility = System.Windows.Visibility.Hidden;
            emptysprite.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Empty_Clicked(object sender, RoutedEventArgs e)
        {
            cola = 0;
            pepsi = 0;
            fanta = 0;
            sevenup = 0;
            sprite = 0;

            tbInvCola.Text = "Coca Cola: " + cola + "db";
            tbInvPepsi.Text = "Pepsi: " + pepsi + "db";
            tbInvFanta.Text = "Fanta: " + fanta + "db";
            tbInv7up.Text = "7up: " + sevenup + "db";
            tbInvSprite.Text = "Sprite: " + sprite + "db";

            emptycola.Visibility = System.Windows.Visibility.Visible;
            emptypepsi.Visibility = System.Windows.Visibility.Visible;
            emptyfanta.Visibility = System.Windows.Visibility.Visible;
            empty7up.Visibility = System.Windows.Visibility.Visible;
            emptysprite.Visibility = System.Windows.Visibility.Visible;
        }

        private void Withdraw_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pénztár kiürítve. Ez " + balance + "Ft a zsebbe.");
            balance = 0;
            tbBalance.Text = "Pénztár: " + balance + "Ft";
        }

        private void Insert_Clicked_50(object sender, RoutedEventArgs e)
        {
            inserted += 50;
            tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
        }

        private void Insert_Clicked_100(object sender, RoutedEventArgs e)
        {
            inserted += 100;
            tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
        }

        private void Insert_Clicked_200(object sender, RoutedEventArgs e)
        {
            inserted += 200;
            tbinserted.Text ="Bedobott apró: " + inserted + "Ft";
        }
        private void Purchase_Clicked_Cola(object sender, RoutedEventArgs e)
        {
            if (inserted - 450 >= 0)
            {
                if(cola - 1 >= 0) 
                { 
                    inserted -= 450;
                    tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
                    balance += 450;
                    tbBalance.Text = "Pénztár: " + balance + "Ft";
                    cola -= 1;
                    tbInvCola.Text = "Coca Cola: " + cola + "db";
                    if(cola == 0)
                    {
                        emptycola.Visibility = System.Windows.Visibility.Visible;
                    }
                    MessageBox.Show("Sikeres vásárlás!");
                }
                else 
                {
                    MessageBox.Show("Nincs készleten. Várja meg a készletfeltöltést!");
                }
            }
            else 
            {
                MessageBox.Show("Nincs elég egyenlege. Dobjon be néhány aprót és próbálja újra!");
            }
        }
        private void Purchase_Clicked_Pepsi(object sender, RoutedEventArgs e)
        {
            if (inserted - 500 >= 0)
            {
                if (pepsi - 1 >= 0)
                {
                    inserted -= 500;
                    tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
                    balance += 450;
                    tbBalance.Text = "Pénztár: " + balance + "Ft";
                    pepsi -= 1;
                    tbInvPepsi.Text = "Pepsi: " + pepsi + "db";
                    if (pepsi == 0)
                    {
                        emptypepsi.Visibility = System.Windows.Visibility.Visible;
                    }
                    MessageBox.Show("Sikeres vásárlás!");
                }
                else
                {
                    MessageBox.Show("Nincs készleten. Várja meg a készletfeltöltést!");
                }
            }
            else
            {
                MessageBox.Show("Nincs elég egyenlege. Dobjon be néhány aprót és próbálja újra!");
            }
        }
        private void Purchase_Clicked_Fanta(object sender, RoutedEventArgs e)
        {
            if (inserted - 400 >= 0)
            {
                if (fanta - 1 >= 0)
                {
                    inserted -= 400;
                    tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
                    balance += 400;
                    tbBalance.Text = "Pénztár: " + balance + "Ft";
                    fanta -= 1;
                    tbInvFanta.Text = "Fanta: " + fanta + "db";
                    if (fanta == 0)
                    {
                        emptyfanta.Visibility = System.Windows.Visibility.Visible;
                    }
                    MessageBox.Show("Sikeres vásárlás!");
                }
                else
                {
                    MessageBox.Show("Nincs készleten. Várja meg a készletfeltöltést!");
                }
            }
            else
            {
                MessageBox.Show("Nincs elég egyenlege. Dobjon be néhány aprót és próbálja újra!");
            }
        }
        private void Purchase_Clicked_7up(object sender, RoutedEventArgs e)
        {
            if (inserted - 300 >= 0)
            {
                if (sevenup - 1 >= 0)
                {
                    inserted -= 300;
                    tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
                    balance += 300;
                    tbBalance.Text = "Pénztár: " + balance + "Ft";
                    sevenup -= 1;
                    tbInv7up.Text = "7up: " + sevenup + "db";
                    if (sevenup == 0)
                    {
                        empty7up.Visibility = System.Windows.Visibility.Visible;
                    }
                    MessageBox.Show("Sikeres vásárlás!");
                }
                else
                {
                    MessageBox.Show("Nincs készleten. Várja meg a készletfeltöltést!");
                }
            }
            else
            {
                MessageBox.Show("Nincs elég egyenlege. Dobjon be néhány aprót és próbálja újra!");
            }
        }
        private void Purchase_Clicked_Sprite(object sender, RoutedEventArgs e)
        {
            if (inserted - 350 >= 0)
            {
                if (sprite - 1 >= 0)
                {
                    inserted -= 350;
                    tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
                    balance += 350;
                    tbBalance.Text = "Pénztár: " + balance + "Ft";
                    sprite -= 1;
                    tbInvSprite.Text = "Sprite: " + sprite + "db";
                    if (sprite == 0)
                    {
                        emptysprite.Visibility = System.Windows.Visibility.Visible;
                    }
                    MessageBox.Show("Sikeres vásárlás!");
                }
                else
                {
                    MessageBox.Show("Nincs készleten. Várja meg a készletfeltöltést!");
                }
            }
            else
            {
                MessageBox.Show("Nincs elég egyenlege. Dobjon be néhány aprót és próbálja újra!");
            }
        }
        private void Give_Change(object sender, RoutedEventArgs e)
        {
            tbchange.Text = "Visszajáró: " + inserted + "Ft";
            inserted = 0;
            tbinserted.Text = "Bedobott apró: " + inserted + "Ft";
        }
    }
}
